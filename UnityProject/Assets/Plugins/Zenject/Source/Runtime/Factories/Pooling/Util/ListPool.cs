using System.Collections.Generic;
#if !NOT_UNITY3D
using UnityEngine;
#endif

namespace Zenject
{
    public class ListPool<T> : StaticMemoryPool<List<T>>
    {
        static ListPool<T> _instance = new ListPool<T>();

        public ListPool()
        {
            OnDespawnedMethod = OnDespawned;
        }

        public static ListPool<T> Instance
        {
            get { return _instance; }
        }

        void OnDespawned(List<T> list)
        {
            list.Clear();
        }
    }

#if !NOT_UNITY3D
    static class ListPoolRuntimeState
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        static void ResetStaticState()
        {
            StaticMemoryPoolRegistry.Reset();
        }
    }
#endif
}
