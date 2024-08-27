using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JetBrains.Annotations;

#if UNITASK_PLUGIN
using Cysharp.Threading.Tasks;
#else
using System.Threading.Tasks;
#endif

namespace Zenject
{
    public class MemoryPoolAsync< TValue>
        : MemoryPoolBaseAsync<TValue>, 
          IMemoryPool< TValue>, 
          IFactory< TValue>
    {
        public async
#if UNITASK_PLUGIN
            UniTask<TValue>
#else
            Task<TValue>
#endif
        SpawnAsync()
        {
            var item = await GetInternal();

            if (!Container.IsValidating)
            {
#if ZEN_INTERNAL_PROFILING
                using (ProfileTimers.CreateTimedBlock("User Code"))
#endif
#if UNITY_EDITOR
                using (ProfileBlock.Start("{0}.Reinitialize", GetType()))
#endif
                {
                    Reinitialize( item);
                }
            }

            return item;
        }

        protected virtual void Reinitialize(TValue item)
        {
            // Optional
        }

        public TValue Spawn()
        {
            throw new ZenjectException("Cannot use Spawn in async pool");
        }

        TValue IFactory< TValue>.Create()
        {
            return Spawn();
        }

#if UNITASK_PLUGIN
        UniTask<TValue>
#else
        Task<TValue>
#endif
        IFactory< TValue>.CreateAsync()
        {
            return SpawnAsync();
        }
    }

    public class MemoryPoolAsync<TParam1, TValue>
        : MemoryPoolBaseAsync<TValue>, 
          IMemoryPool<TParam1, TValue>, 
          IFactory<TParam1, TValue>
    {
        public async
#if UNITASK_PLUGIN
            UniTask<TValue>
#else
            Task<TValue>
#endif
        SpawnAsync(TParam1 param1)
        {
            var item = await GetInternal();

            if (!Container.IsValidating)
            {
#if ZEN_INTERNAL_PROFILING
                using (ProfileTimers.CreateTimedBlock("User Code"))
#endif
#if UNITY_EDITOR
                using (ProfileBlock.Start("{0}.Reinitialize", GetType()))
#endif
                {
                    Reinitialize(param1,  item);
                }
            }

            return item;
        }

        protected virtual void Reinitialize(TParam1 param1, TValue item)
        {
            // Optional
        }

        public TValue Spawn(TParam1 param1)
        {
            throw new ZenjectException("Cannot use Spawn in async pool");
        }

        TValue IFactory<TParam1, TValue>.Create(TParam1 param1)
        {
            return Spawn(param1);
        }

#if UNITASK_PLUGIN
        UniTask<TValue>
#else
        Task<TValue>
#endif
        IFactory<TParam1, TValue>.CreateAsync(TParam1 param1)
        {
            return SpawnAsync(param1);
        }
    }

    public class MemoryPoolAsync<TParam1, TParam2, TValue>
        : MemoryPoolBaseAsync<TValue>, 
          IMemoryPool<TParam1, TParam2, TValue>, 
          IFactory<TParam1, TParam2, TValue>
    {
        public async
#if UNITASK_PLUGIN
            UniTask<TValue>
#else
            Task<TValue>
#endif
        SpawnAsync(TParam1 param1, TParam2 param2)
        {
            var item = await GetInternal();

            if (!Container.IsValidating)
            {
#if ZEN_INTERNAL_PROFILING
                using (ProfileTimers.CreateTimedBlock("User Code"))
#endif
#if UNITY_EDITOR
                using (ProfileBlock.Start("{0}.Reinitialize", GetType()))
#endif
                {
                    Reinitialize(param1, param2,  item);
                }
            }

            return item;
        }

        protected virtual void Reinitialize(TParam1 param1, TParam2 param2, TValue item)
        {
            // Optional
        }

        public TValue Spawn(TParam1 param1, TParam2 param2)
        {
            throw new ZenjectException("Cannot use Spawn in async pool");
        }

        TValue IFactory<TParam1, TParam2, TValue>.Create(TParam1 param1, TParam2 param2)
        {
            return Spawn(param1, param2);
        }

#if UNITASK_PLUGIN
        UniTask<TValue>
#else
        Task<TValue>
#endif
        IFactory<TParam1, TParam2, TValue>.CreateAsync(TParam1 param1, TParam2 param2)
        {
            return SpawnAsync(param1, param2);
        }
    }

    public class MemoryPoolAsync<TParam1, TParam2, TParam3, TValue>
        : MemoryPoolBaseAsync<TValue>, 
          IMemoryPool<TParam1, TParam2, TParam3, TValue>, 
          IFactory<TParam1, TParam2, TParam3, TValue>
    {
        public async
#if UNITASK_PLUGIN
            UniTask<TValue>
#else
            Task<TValue>
#endif
        SpawnAsync(TParam1 param1, TParam2 param2, TParam3 param3)
        {
            var item = await GetInternal();

            if (!Container.IsValidating)
            {
#if ZEN_INTERNAL_PROFILING
                using (ProfileTimers.CreateTimedBlock("User Code"))
#endif
#if UNITY_EDITOR
                using (ProfileBlock.Start("{0}.Reinitialize", GetType()))
#endif
                {
                    Reinitialize(param1, param2, param3,  item);
                }
            }

            return item;
        }

        protected virtual void Reinitialize(TParam1 param1, TParam2 param2, TParam3 param3, TValue item)
        {
            // Optional
        }

        public TValue Spawn(TParam1 param1, TParam2 param2, TParam3 param3)
        {
            throw new ZenjectException("Cannot use Spawn in async pool");
        }

        TValue IFactory<TParam1, TParam2, TParam3, TValue>.Create(TParam1 param1, TParam2 param2, TParam3 param3)
        {
            return Spawn(param1, param2, param3);
        }

#if UNITASK_PLUGIN
        UniTask<TValue>
#else
        Task<TValue>
#endif
        IFactory<TParam1, TParam2, TParam3, TValue>.CreateAsync(TParam1 param1, TParam2 param2, TParam3 param3)
        {
            return SpawnAsync(param1, param2, param3);
        }
    }

    public class MemoryPoolAsync<TParam1, TParam2, TParam3, TParam4, TValue>
        : MemoryPoolBaseAsync<TValue>, 
          IMemoryPool<TParam1, TParam2, TParam3, TParam4, TValue>, 
          IFactory<TParam1, TParam2, TParam3, TParam4, TValue>
    {
        public async
#if UNITASK_PLUGIN
            UniTask<TValue>
#else
            Task<TValue>
#endif
        SpawnAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4)
        {
            var item = await GetInternal();

            if (!Container.IsValidating)
            {
#if ZEN_INTERNAL_PROFILING
                using (ProfileTimers.CreateTimedBlock("User Code"))
#endif
#if UNITY_EDITOR
                using (ProfileBlock.Start("{0}.Reinitialize", GetType()))
#endif
                {
                    Reinitialize(param1, param2, param3, param4,  item);
                }
            }

            return item;
        }

        protected virtual void Reinitialize(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TValue item)
        {
            // Optional
        }

        public TValue Spawn(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4)
        {
            throw new ZenjectException("Cannot use Spawn in async pool");
        }

        TValue IFactory<TParam1, TParam2, TParam3, TParam4, TValue>.Create(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4)
        {
            return Spawn(param1, param2, param3, param4);
        }

#if UNITASK_PLUGIN
        UniTask<TValue>
#else
        Task<TValue>
#endif
        IFactory<TParam1, TParam2, TParam3, TParam4, TValue>.CreateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4)
        {
            return SpawnAsync(param1, param2, param3, param4);
        }
    }

    public class MemoryPoolAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TValue>
        : MemoryPoolBaseAsync<TValue>, 
          IMemoryPool<TParam1, TParam2, TParam3, TParam4, TParam5, TValue>, 
          IFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TValue>
    {
        public async
#if UNITASK_PLUGIN
            UniTask<TValue>
#else
            Task<TValue>
#endif
        SpawnAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5)
        {
            var item = await GetInternal();

            if (!Container.IsValidating)
            {
#if ZEN_INTERNAL_PROFILING
                using (ProfileTimers.CreateTimedBlock("User Code"))
#endif
#if UNITY_EDITOR
                using (ProfileBlock.Start("{0}.Reinitialize", GetType()))
#endif
                {
                    Reinitialize(param1, param2, param3, param4, param5,  item);
                }
            }

            return item;
        }

        protected virtual void Reinitialize(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TValue item)
        {
            // Optional
        }

        public TValue Spawn(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5)
        {
            throw new ZenjectException("Cannot use Spawn in async pool");
        }

        TValue IFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TValue>.Create(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5)
        {
            return Spawn(param1, param2, param3, param4, param5);
        }

#if UNITASK_PLUGIN
        UniTask<TValue>
#else
        Task<TValue>
#endif
        IFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TValue>.CreateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5)
        {
            return SpawnAsync(param1, param2, param3, param4, param5);
        }
    }

    public class MemoryPoolAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TValue>
        : MemoryPoolBaseAsync<TValue>, 
          IMemoryPool<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TValue>, 
          IFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TValue>
    {
        public async
#if UNITASK_PLUGIN
            UniTask<TValue>
#else
            Task<TValue>
#endif
        SpawnAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6)
        {
            var item = await GetInternal();

            if (!Container.IsValidating)
            {
#if ZEN_INTERNAL_PROFILING
                using (ProfileTimers.CreateTimedBlock("User Code"))
#endif
#if UNITY_EDITOR
                using (ProfileBlock.Start("{0}.Reinitialize", GetType()))
#endif
                {
                    Reinitialize(param1, param2, param3, param4, param5, param6,  item);
                }
            }

            return item;
        }

        protected virtual void Reinitialize(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TValue item)
        {
            // Optional
        }

        public TValue Spawn(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6)
        {
            throw new ZenjectException("Cannot use Spawn in async pool");
        }

        TValue IFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TValue>.Create(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6)
        {
            return Spawn(param1, param2, param3, param4, param5, param6);
        }

#if UNITASK_PLUGIN
        UniTask<TValue>
#else
        Task<TValue>
#endif
        IFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TValue>.CreateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6)
        {
            return SpawnAsync(param1, param2, param3, param4, param5, param6);
        }
    }

    public class MemoryPoolAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TValue>
        : MemoryPoolBaseAsync<TValue>, 
          IMemoryPool<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TValue>, 
          IFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TValue>
    {
        public async
#if UNITASK_PLUGIN
            UniTask<TValue>
#else
            Task<TValue>
#endif
        SpawnAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7)
        {
            var item = await GetInternal();

            if (!Container.IsValidating)
            {
#if ZEN_INTERNAL_PROFILING
                using (ProfileTimers.CreateTimedBlock("User Code"))
#endif
#if UNITY_EDITOR
                using (ProfileBlock.Start("{0}.Reinitialize", GetType()))
#endif
                {
                    Reinitialize(param1, param2, param3, param4, param5, param6, param7,  item);
                }
            }

            return item;
        }

        protected virtual void Reinitialize(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TValue item)
        {
            // Optional
        }

        public TValue Spawn(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7)
        {
            throw new ZenjectException("Cannot use Spawn in async pool");
        }

        TValue IFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TValue>.Create(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7)
        {
            return Spawn(param1, param2, param3, param4, param5, param6, param7);
        }

#if UNITASK_PLUGIN
        UniTask<TValue>
#else
        Task<TValue>
#endif
        IFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TValue>.CreateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7)
        {
            return SpawnAsync(param1, param2, param3, param4, param5, param6, param7);
        }
    }

    public class MemoryPoolAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TValue>
        : MemoryPoolBaseAsync<TValue>, 
          IMemoryPool<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TValue>, 
          IFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TValue>
    {
        public async
#if UNITASK_PLUGIN
            UniTask<TValue>
#else
            Task<TValue>
#endif
        SpawnAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8)
        {
            var item = await GetInternal();

            if (!Container.IsValidating)
            {
#if ZEN_INTERNAL_PROFILING
                using (ProfileTimers.CreateTimedBlock("User Code"))
#endif
#if UNITY_EDITOR
                using (ProfileBlock.Start("{0}.Reinitialize", GetType()))
#endif
                {
                    Reinitialize(param1, param2, param3, param4, param5, param6, param7, param8,  item);
                }
            }

            return item;
        }

        protected virtual void Reinitialize(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TValue item)
        {
            // Optional
        }

        public TValue Spawn(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8)
        {
            throw new ZenjectException("Cannot use Spawn in async pool");
        }

        TValue IFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TValue>.Create(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8)
        {
            return Spawn(param1, param2, param3, param4, param5, param6, param7, param8);
        }

#if UNITASK_PLUGIN
        UniTask<TValue>
#else
        Task<TValue>
#endif
        IFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TValue>.CreateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8)
        {
            return SpawnAsync(param1, param2, param3, param4, param5, param6, param7, param8);
        }
    }

    public class MemoryPoolAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TValue>
        : MemoryPoolBaseAsync<TValue>, 
          IMemoryPool<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TValue>, 
          IFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TValue>
    {
        public async
#if UNITASK_PLUGIN
            UniTask<TValue>
#else
            Task<TValue>
#endif
        SpawnAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9)
        {
            var item = await GetInternal();

            if (!Container.IsValidating)
            {
#if ZEN_INTERNAL_PROFILING
                using (ProfileTimers.CreateTimedBlock("User Code"))
#endif
#if UNITY_EDITOR
                using (ProfileBlock.Start("{0}.Reinitialize", GetType()))
#endif
                {
                    Reinitialize(param1, param2, param3, param4, param5, param6, param7, param8, param9,  item);
                }
            }

            return item;
        }

        protected virtual void Reinitialize(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9, TValue item)
        {
            // Optional
        }

        public TValue Spawn(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9)
        {
            throw new ZenjectException("Cannot use Spawn in async pool");
        }

        TValue IFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TValue>.Create(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9)
        {
            return Spawn(param1, param2, param3, param4, param5, param6, param7, param8, param9);
        }

#if UNITASK_PLUGIN
        UniTask<TValue>
#else
        Task<TValue>
#endif
        IFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TValue>.CreateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9)
        {
            return SpawnAsync(param1, param2, param3, param4, param5, param6, param7, param8, param9);
        }
    }

    public class MemoryPoolAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TValue>
        : MemoryPoolBaseAsync<TValue>, 
          IMemoryPool<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TValue>, 
          IFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TValue>
    {
        public async
#if UNITASK_PLUGIN
            UniTask<TValue>
#else
            Task<TValue>
#endif
        SpawnAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9, TParam10 param10)
        {
            var item = await GetInternal();

            if (!Container.IsValidating)
            {
#if ZEN_INTERNAL_PROFILING
                using (ProfileTimers.CreateTimedBlock("User Code"))
#endif
#if UNITY_EDITOR
                using (ProfileBlock.Start("{0}.Reinitialize", GetType()))
#endif
                {
                    Reinitialize(param1, param2, param3, param4, param5, param6, param7, param8, param9, param10,  item);
                }
            }

            return item;
        }

        protected virtual void Reinitialize(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9, TParam10 param10, TValue item)
        {
            // Optional
        }

        public TValue Spawn(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9, TParam10 param10)
        {
            throw new ZenjectException("Cannot use Spawn in async pool");
        }

        TValue IFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TValue>.Create(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9, TParam10 param10)
        {
            return Spawn(param1, param2, param3, param4, param5, param6, param7, param8, param9, param10);
        }

#if UNITASK_PLUGIN
        UniTask<TValue>
#else
        Task<TValue>
#endif
        IFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TValue>.CreateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9, TParam10 param10)
        {
            return SpawnAsync(param1, param2, param3, param4, param5, param6, param7, param8, param9, param10);
        }
    }

}