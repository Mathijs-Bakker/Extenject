using UnityEngine;
using Zenject;

namespace Zenject.Tests.Installers.CompositeScriptableObjectInstallers
{
    // [CreateAssetMenu(fileName = "FooInjecteeInstaller", menuName = "Installers/FooInjecteeInstaller")]
    public class FooInjecteeInstaller : ScriptableObjectInstaller<FooInjecteeInstaller>
    {
        public override void InstallBindings()
        {
            Container
                .Bind<FooInjectee>()
                .AsSingle()
                .NonLazy();
        }
    }
}