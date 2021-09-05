using UnityEngine;
using Zenject;

namespace Zenject.Tests.Installers.CompositeScriptableObjectInstallers
{
    // [CreateAssetMenu(fileName = "FooInstaller", menuName = "Installers/FooInstaller")]
    public class FooInstaller : ScriptableObjectInstaller<FooInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<Foo>().AsSingle().NonLazy();
        }
    }
}