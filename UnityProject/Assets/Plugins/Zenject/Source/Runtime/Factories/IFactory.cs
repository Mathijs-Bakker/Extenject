#if UNITASK_PLUGIN
using Cysharp.Threading.Tasks;
#else
using System.Threading.Tasks;
#endif

namespace Zenject
{
    public interface IFactory
    {
        bool IsAsync => false;
    }
}