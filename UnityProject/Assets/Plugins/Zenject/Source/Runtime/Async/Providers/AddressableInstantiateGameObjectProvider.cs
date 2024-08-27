using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Zenject
{
    public class AddressableInstantiateGameObjectProvider : AddressableInstantiateProviderBase
    {
        public AddressableInstantiateGameObjectProvider(
            DiContainer diContainer,
            GameObjectCreationParameters gameObjectBindInfo,
            IEnumerable<Type> instantiateCallbackTypes,
            IEnumerable<TypeValuePair> extraArguments,
            Action<InjectContext, object> instantiateCallback,
            AssetReference assetReference)
            : base(
                diContainer,
                gameObjectBindInfo,
                instantiateCallbackTypes,
                extraArguments,
                instantiateCallback,
                assetReference,
                typeof(GameObject),
                instantiator => new PrefabGameObjectProvider(instantiator))
        {
        }
    }
}