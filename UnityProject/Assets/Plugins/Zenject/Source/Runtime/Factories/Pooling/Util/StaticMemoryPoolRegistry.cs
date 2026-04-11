using System;
using System.Collections.Generic;
using ModestTree;
#if !NOT_UNITY3D
using UnityEngine;
#endif

namespace Zenject
{
    internal interface IResettableStaticMemoryPool
    {
        void ResetPool();
    }

    public static class StaticMemoryPoolRegistry
    {
        public static event Action<IMemoryPool> PoolAdded = delegate {};
        public static event Action<IMemoryPool> PoolRemoved = delegate {};

        static readonly List<IMemoryPool> PoolsInternal = new List<IMemoryPool>();

        public static IEnumerable<IMemoryPool> Pools
        {
            get { return PoolsInternal; }
        }

        public static void Add(IMemoryPool memoryPool)
        {
            PoolsInternal.Add(memoryPool);
            PoolAdded(memoryPool);
        }

        public static void Remove(IMemoryPool memoryPool)
        {
            PoolsInternal.RemoveWithConfirm(memoryPool);
            PoolRemoved(memoryPool);
        }

        public static void Reset()
        {
            for (var i = PoolsInternal.Count - 1; i >= 0; i--)
            {
                var pool = PoolsInternal[i] as IResettableStaticMemoryPool;

                if (pool == null)
                {
                    PoolsInternal.RemoveAt(i);
                    continue;
                }

                pool.ResetPool();
            }
        }

#if !NOT_UNITY3D
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        static void ResetStaticState()
        {
            Reset();
            PoolAdded = delegate {};
            PoolRemoved = delegate {};
        }
#endif
    }
}
