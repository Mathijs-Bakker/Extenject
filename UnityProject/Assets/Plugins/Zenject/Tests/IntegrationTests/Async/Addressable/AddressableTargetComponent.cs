using ModestTree;
using UnityEngine;

namespace Zenject.Tests.IntegrationTests.Async.Addressable
{
    public class AddressableTargetComponent : MonoBehaviour, IPoolable<int, IMemoryPool>
    {
        [InjectOptional] public int InjectedValue;
        
        public class Factory : PlaceholderFactory<int, AddressableTargetComponent>
        {
        }

        public void OnDespawned()
        {
            
        }

        public void OnSpawned(int p1, IMemoryPool p2)
        {
            InjectedValue = p1;
            Assert.IsNotNull(p2);
        }
    }
}