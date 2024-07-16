using System;
using System.Collections.Generic;
using System.Threading;
using ModestTree;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using Object = UnityEngine.Object;

#if UNITASK_PLUGIN
using Cysharp.Threading.Tasks;
using TaskObject = Cysharp.Threading.Tasks.UniTask<UnityEngine.Object>;
#else
using TaskObject = System.Threading.Tasks.Task<UnityEngine.Object>;
#endif


namespace Zenject
{
    public class AddressableInstantiateProviderBase : IProvider, IDisposable
    {
        readonly Type _componentType;
        readonly AssetReference _assetReference;
        readonly DiContainer _diContainer;
        readonly GameObjectCreationParameters _gameObjectBindInfo;
        readonly IEnumerable<Type> _instantiateCallbackTypes;
        readonly IEnumerable<TypeValuePair> _extraArguments;
        readonly Action<InjectContext, object> _instantiateCallback;
        readonly Func<IPrefabInstantiator, IProvider> _subProviderFactory;
        
        AsyncOperationHandle<Object> _loadPrefabHandle;
        IProvider _subProvider;

        // if concreteType is null we use the contract type from inject context
        public AddressableInstantiateProviderBase(
            DiContainer diContainer,
            GameObjectCreationParameters gameObjectBindInfo,
            IEnumerable<Type> instantiateCallbackTypes,
            IEnumerable<TypeValuePair> extraArguments,
            Action<InjectContext, object> instantiateCallback,
            AssetReference assetReference,
            Type componentType,
            Func<IPrefabInstantiator, IProvider> subProviderFactory)
        {
            _subProviderFactory = subProviderFactory;
            _instantiateCallback = instantiateCallback;
            _extraArguments = extraArguments;
            _instantiateCallbackTypes = instantiateCallbackTypes;
            _gameObjectBindInfo = gameObjectBindInfo;
            _diContainer = diContainer;
            _assetReference = assetReference;
            _componentType = componentType;
        }

        public bool IsAsync => true;
        public bool TypeVariesBasedOnMemberType => false;
        public bool IsCached => false;

        public Type GetInstanceType(InjectContext context)
        {
            return _componentType;
        }

        public void GetAllInstancesWithInjectSplit(InjectContext context, List<TypeValuePair> args, out Action injectAction, List<object> instances)
        {
            Assert.IsNotNull(context);

            injectAction = null;

            instances.Add(new AsyncInject<Object>(context, args, InstantiateObject));
        }

        private async TaskObject InstantiateObject(InjectContext inContext, List<TypeValuePair> inArgs, CancellationToken cancellationToken)
        {
            if (_subProvider == null)
            {
                _loadPrefabHandle = Addressables.LoadAssetAsync<Object>(_assetReference);

#if UNITASK_PLUGIN
                await _loadPrefabHandle.ToUniTask();
#else
                await _loadPrefabHandle.Task;
#endif

                if (cancellationToken.IsCancellationRequested)
                {
                    Addressables.Release(_loadPrefabHandle);
                    _loadPrefabHandle = default;
                    cancellationToken.ThrowIfCancellationRequested();
                }

                var prefabProvider = new PrefabProvider(_loadPrefabHandle.Result);
                var prefabInstantiator = new PrefabInstantiator(
                    _diContainer,
                    _gameObjectBindInfo,
                    _componentType,
                    _instantiateCallbackTypes,
                    _extraArguments,
                    prefabProvider,
                    _instantiateCallback
                );
                _subProvider = _subProviderFactory(prefabInstantiator);
            }

            using DisposeBlock disposeBlock = DisposeBlock.Spawn();
            List<object> buffer = disposeBlock.SpawnList<object>();
            _subProvider.GetAllInstances(inContext, inArgs, buffer);
            return (Object) buffer[0];
        }

        void IDisposable.Dispose()
        {
            if (_loadPrefabHandle.IsValid())
            {
                Addressables.Release(_loadPrefabHandle);
                _loadPrefabHandle = default;
                _subProvider = null;
            }
        }
    }
}