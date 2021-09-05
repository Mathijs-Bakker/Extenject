using UnityEngine;
using Zenject;

namespace Zenject.Tests.Installers.CompositeMonoInstallers
{
    public class BarInstaller : MonoInstaller<BarInstaller>
    {
        [SerializeField] string _value;

        public override void InstallBindings()
        {
            Container.BindInstance(_value);
        }
    }
}
