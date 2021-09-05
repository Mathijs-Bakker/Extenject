using UnityEngine;
using Zenject;

namespace Zenject.Tests.Installers.CompositeMonoInstallers
{
    public class QuxInstaller : MonoInstaller<QuxInstaller>
    {
        [SerializeField] string _p1;
        [SerializeField] float _p2;
        [SerializeField] int _p3;

        public override void InstallBindings()
        {
            Container.BindInstance(_p1);
            Container.BindInstance(_p2);
            Container.BindInstance(_p3);
        }
    }
}
