using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JetBrains.Annotations;
using UnityEngine;

#if UNITASK_PLUGIN
using Cysharp.Threading.Tasks;
#else
using System.Threading.Tasks;
#endif

namespace Zenject
{
    public static class FactoryPoolAsyncBinder
    {
        public static ArgConditionCopyNonLazyBinder FromMonoPoolableMemoryPoolAsync<TContract>(
            this FactoryFromBinder<TContract> fromBinder)
            // Unfortunately we have to pass the same contract in again to satisfy the generic
            // constraints below
            where TContract : Component, IPoolable<IMemoryPool>
        {
            return fromBinder.FromMonoPoolableMemoryPoolAsync<TContract>(x => {});
        }

        public static ArgConditionCopyNonLazyBinder FromMonoPoolableMemoryPoolAsync<TContract>(
            this FactoryFromBinder<TContract> fromBinder,
            Action<MemoryPoolInitialSizeMaxSizeBinder<TContract>> poolBindGenerator)
            // Unfortunately we have to pass the same contract in again to satisfy the generic
            // constraints below
            where TContract : Component, IPoolable<IMemoryPool>
        {
            return fromBinder.FromPoolableMemoryPool<TContract, MonoPoolableMemoryPoolAsync<IMemoryPool, TContract>>(poolBindGenerator);
        }
        public static ArgConditionCopyNonLazyBinder FromMonoPoolableMemoryPoolAsync<TParam1,TContract>(
            this FactoryFromBinder<TParam1,TContract> fromBinder)
            // Unfortunately we have to pass the same contract in again to satisfy the generic
            // constraints below
            where TContract : Component, IPoolable<TParam1,IMemoryPool>
        {
            return fromBinder.FromMonoPoolableMemoryPoolAsync<TParam1,TContract>(x => {});
        }

        public static ArgConditionCopyNonLazyBinder FromMonoPoolableMemoryPoolAsync<TParam1,TContract>(
            this FactoryFromBinder<TParam1,TContract> fromBinder,
            Action<MemoryPoolInitialSizeMaxSizeBinder<TContract>> poolBindGenerator)
            // Unfortunately we have to pass the same contract in again to satisfy the generic
            // constraints below
            where TContract : Component, IPoolable<TParam1,IMemoryPool>
        {
            return fromBinder.FromPoolableMemoryPool<TParam1,TContract, MonoPoolableMemoryPoolAsync<TParam1,IMemoryPool, TContract>>(poolBindGenerator);
        }
        public static ArgConditionCopyNonLazyBinder FromMonoPoolableMemoryPoolAsync<TParam1, TParam2,TContract>(
            this FactoryFromBinder<TParam1, TParam2,TContract> fromBinder)
            // Unfortunately we have to pass the same contract in again to satisfy the generic
            // constraints below
            where TContract : Component, IPoolable<TParam1, TParam2,IMemoryPool>
        {
            return fromBinder.FromMonoPoolableMemoryPoolAsync<TParam1, TParam2,TContract>(x => {});
        }

        public static ArgConditionCopyNonLazyBinder FromMonoPoolableMemoryPoolAsync<TParam1, TParam2,TContract>(
            this FactoryFromBinder<TParam1, TParam2,TContract> fromBinder,
            Action<MemoryPoolInitialSizeMaxSizeBinder<TContract>> poolBindGenerator)
            // Unfortunately we have to pass the same contract in again to satisfy the generic
            // constraints below
            where TContract : Component, IPoolable<TParam1, TParam2,IMemoryPool>
        {
            return fromBinder.FromPoolableMemoryPool<TParam1, TParam2,TContract, MonoPoolableMemoryPoolAsync<TParam1, TParam2,IMemoryPool, TContract>>(poolBindGenerator);
        }
        public static ArgConditionCopyNonLazyBinder FromMonoPoolableMemoryPoolAsync<TParam1, TParam2, TParam3,TContract>(
            this FactoryFromBinder<TParam1, TParam2, TParam3,TContract> fromBinder)
            // Unfortunately we have to pass the same contract in again to satisfy the generic
            // constraints below
            where TContract : Component, IPoolable<TParam1, TParam2, TParam3,IMemoryPool>
        {
            return fromBinder.FromMonoPoolableMemoryPoolAsync<TParam1, TParam2, TParam3,TContract>(x => {});
        }

        public static ArgConditionCopyNonLazyBinder FromMonoPoolableMemoryPoolAsync<TParam1, TParam2, TParam3,TContract>(
            this FactoryFromBinder<TParam1, TParam2, TParam3,TContract> fromBinder,
            Action<MemoryPoolInitialSizeMaxSizeBinder<TContract>> poolBindGenerator)
            // Unfortunately we have to pass the same contract in again to satisfy the generic
            // constraints below
            where TContract : Component, IPoolable<TParam1, TParam2, TParam3,IMemoryPool>
        {
            return fromBinder.FromPoolableMemoryPool<TParam1, TParam2, TParam3,TContract, MonoPoolableMemoryPoolAsync<TParam1, TParam2, TParam3,IMemoryPool, TContract>>(poolBindGenerator);
        }
        public static ArgConditionCopyNonLazyBinder FromMonoPoolableMemoryPoolAsync<TParam1, TParam2, TParam3, TParam4,TContract>(
            this FactoryFromBinder<TParam1, TParam2, TParam3, TParam4,TContract> fromBinder)
            // Unfortunately we have to pass the same contract in again to satisfy the generic
            // constraints below
            where TContract : Component, IPoolable<TParam1, TParam2, TParam3, TParam4,IMemoryPool>
        {
            return fromBinder.FromMonoPoolableMemoryPoolAsync<TParam1, TParam2, TParam3, TParam4,TContract>(x => {});
        }

        public static ArgConditionCopyNonLazyBinder FromMonoPoolableMemoryPoolAsync<TParam1, TParam2, TParam3, TParam4,TContract>(
            this FactoryFromBinder<TParam1, TParam2, TParam3, TParam4,TContract> fromBinder,
            Action<MemoryPoolInitialSizeMaxSizeBinder<TContract>> poolBindGenerator)
            // Unfortunately we have to pass the same contract in again to satisfy the generic
            // constraints below
            where TContract : Component, IPoolable<TParam1, TParam2, TParam3, TParam4,IMemoryPool>
        {
            return fromBinder.FromPoolableMemoryPool<TParam1, TParam2, TParam3, TParam4,TContract, MonoPoolableMemoryPoolAsync<TParam1, TParam2, TParam3, TParam4,IMemoryPool, TContract>>(poolBindGenerator);
        }
        public static ArgConditionCopyNonLazyBinder FromMonoPoolableMemoryPoolAsync<TParam1, TParam2, TParam3, TParam4, TParam5,TContract>(
            this FactoryFromBinder<TParam1, TParam2, TParam3, TParam4, TParam5,TContract> fromBinder)
            // Unfortunately we have to pass the same contract in again to satisfy the generic
            // constraints below
            where TContract : Component, IPoolable<TParam1, TParam2, TParam3, TParam4, TParam5,IMemoryPool>
        {
            return fromBinder.FromMonoPoolableMemoryPoolAsync<TParam1, TParam2, TParam3, TParam4, TParam5,TContract>(x => {});
        }

        public static ArgConditionCopyNonLazyBinder FromMonoPoolableMemoryPoolAsync<TParam1, TParam2, TParam3, TParam4, TParam5,TContract>(
            this FactoryFromBinder<TParam1, TParam2, TParam3, TParam4, TParam5,TContract> fromBinder,
            Action<MemoryPoolInitialSizeMaxSizeBinder<TContract>> poolBindGenerator)
            // Unfortunately we have to pass the same contract in again to satisfy the generic
            // constraints below
            where TContract : Component, IPoolable<TParam1, TParam2, TParam3, TParam4, TParam5,IMemoryPool>
        {
            return fromBinder.FromPoolableMemoryPool<TParam1, TParam2, TParam3, TParam4, TParam5,TContract, MonoPoolableMemoryPoolAsync<TParam1, TParam2, TParam3, TParam4, TParam5,IMemoryPool, TContract>>(poolBindGenerator);
        }
        public static ArgConditionCopyNonLazyBinder FromMonoPoolableMemoryPoolAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6,TContract>(
            this FactoryFromBinder<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6,TContract> fromBinder)
            // Unfortunately we have to pass the same contract in again to satisfy the generic
            // constraints below
            where TContract : Component, IPoolable<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6,IMemoryPool>
        {
            return fromBinder.FromMonoPoolableMemoryPoolAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6,TContract>(x => {});
        }

        public static ArgConditionCopyNonLazyBinder FromMonoPoolableMemoryPoolAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6,TContract>(
            this FactoryFromBinder<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6,TContract> fromBinder,
            Action<MemoryPoolInitialSizeMaxSizeBinder<TContract>> poolBindGenerator)
            // Unfortunately we have to pass the same contract in again to satisfy the generic
            // constraints below
            where TContract : Component, IPoolable<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6,IMemoryPool>
        {
            return fromBinder.FromPoolableMemoryPool<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6,TContract, MonoPoolableMemoryPoolAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6,IMemoryPool, TContract>>(poolBindGenerator);
        }
    }
}