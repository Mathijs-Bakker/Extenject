using System.Collections.Generic;
using UnityEngine;
using ModestTree;

namespace Zenject
{
    public class CompositeMonoInstaller : MonoInstaller<CompositeMonoInstaller>, ICompositeInstaller<MonoInstallerBase>
    {
        [SerializeField]
        List<MonoInstallerBase> _leafInstallers = new List<MonoInstallerBase>();
        public IReadOnlyList<MonoInstallerBase> LeafInstallers => _leafInstallers;

        public override void InstallBindings()
        {
            Assert.That(this.ValidateLeafInstallers(), "Found some circular references in {0}".Fmt(name));

            foreach (var installer in _leafInstallers)
            {
                Container.Inject(installer);

#if ZEN_INTERNAL_PROFILING
                using (ProfileTimers.CreateTimedBlock("User Code"))
#endif
                {
                    installer.InstallBindings();
                }
            }
        }
    }
}