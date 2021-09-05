using UnityEngine;
using Zenject;

namespace Zenject.Tests.Installers.CompositeMonoInstallers
{
    public class FooInstaller : MonoInstaller<FooInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<Foo>().AsSingle().NonLazy();
        }
    }
}