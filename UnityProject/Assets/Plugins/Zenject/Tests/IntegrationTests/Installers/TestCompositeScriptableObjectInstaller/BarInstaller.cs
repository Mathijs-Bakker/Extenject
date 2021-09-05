using UnityEngine;
using Zenject;

namespace Zenject.Tests.Installers.CompositeScriptableObjectInstallers
{
    // [CreateAssetMenu(fileName = "BarInstaller", menuName = "Installers/BarInstaller")]
    public class BarInstaller : ScriptableObjectInstaller<BarInstaller>
    {
        [SerializeField] string _value;

        public override void InstallBindings()
        {
            Container.BindInstance(_value);
        }
    }
}
