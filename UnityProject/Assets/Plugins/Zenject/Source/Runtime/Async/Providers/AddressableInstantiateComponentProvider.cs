using System;
using System.Collections.Generic;
using UnityEngine.AddressableAssets;


namespace Zenject
{
    public class AddressableInstantiateComponentProvider : AddressableInstantiateProviderBase
    {
        public AddressableInstantiateComponentProvider(
            DiContainer diContainer,
            GameObjectCreationParameters gameObjectBindInfo,
            IEnumerable<Type> instantiateCallbackTypes,
            IEnumerable<TypeValuePair> extraArguments,
            Action<InjectContext, object> instantiateCallback,
            AssetReference assetReference,
            Type componentType,
            bool matchSingle)
            : base(
                diContainer,
                gameObjectBindInfo,
                instantiateCallbackTypes,
                extraArguments,
                instantiateCallback,
                assetReference,
                componentType,
                (instantiator) => new GetFromPrefabComponentProvider(componentType, instantiator, matchSingle)
            )
        {
        }
    }
}