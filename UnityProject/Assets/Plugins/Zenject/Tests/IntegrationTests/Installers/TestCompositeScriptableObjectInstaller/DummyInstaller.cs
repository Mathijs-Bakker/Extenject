using UnityEngine;
using Zenject;

namespace Zenject.Tests.Installers.CompositeScriptableObjectInstallers
{
    // [CreateAssetMenu(fileName = "DummyInstaller", menuName = "Installers/DummyInstaller")]
    public class DummyInstaller : ScriptableObjectInstaller<DummyInstaller>
    {
        public override void InstallBindings()
        {
        }
    }
}