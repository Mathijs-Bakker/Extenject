using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JetBrains.Annotations;

#if UNITASK_PLUGIN
using Cysharp.Threading.Tasks;
using Task = Cysharp.Threading.Tasks.UniTask;
#else
using System.Threading.Tasks;
using Task = System.Threading.Tasks.Task;
#endif

namespace Zenject
{
    public interface IMemoryPool<TValue> : IDespawnableMemoryPool<TValue>
    {
        TValue Spawn();

#if UNITASK_PLUGIN
        UniTask<TValue>
#else
        Task<TValue>
#endif
        SpawnAsync() => Task.FromResult(Spawn());
    }

    public interface IMemoryPool<in TParam1, TValue> : IDespawnableMemoryPool<TValue>
    {
        TValue Spawn(TParam1 param1);

#if UNITASK_PLUGIN
        UniTask<TValue>
#else
        Task<TValue>
#endif
        SpawnAsync(TParam1 param1) => Task.FromResult(Spawn(param1));
    }

    public interface IMemoryPool<in TParam1, in TParam2, TValue> : IDespawnableMemoryPool<TValue>
    {
        TValue Spawn(TParam1 param1, TParam2 param2);

#if UNITASK_PLUGIN
        UniTask<TValue>
#else
        Task<TValue>
#endif
        SpawnAsync(TParam1 param1, TParam2 param2) => Task.FromResult(Spawn(param1, param2));
    }

    public interface IMemoryPool<in TParam1, in TParam2, in TParam3, TValue> : IDespawnableMemoryPool<TValue>
    {
        TValue Spawn(TParam1 param1, TParam2 param2, TParam3 param3);

#if UNITASK_PLUGIN
        UniTask<TValue>
#else
        Task<TValue>
#endif
        SpawnAsync(TParam1 param1, TParam2 param2, TParam3 param3) => Task.FromResult(Spawn(param1, param2, param3));
    }

    public interface IMemoryPool<in TParam1, in TParam2, in TParam3, in TParam4, TValue> : IDespawnableMemoryPool<TValue>
    {
        TValue Spawn(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4);

#if UNITASK_PLUGIN
        UniTask<TValue>
#else
        Task<TValue>
#endif
        SpawnAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4) => Task.FromResult(Spawn(param1, param2, param3, param4));
    }

    public interface IMemoryPool<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, TValue> : IDespawnableMemoryPool<TValue>
    {
        TValue Spawn(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5);

#if UNITASK_PLUGIN
        UniTask<TValue>
#else
        Task<TValue>
#endif
        SpawnAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5) => Task.FromResult(Spawn(param1, param2, param3, param4, param5));
    }

    public interface IMemoryPool<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, TValue> : IDespawnableMemoryPool<TValue>
    {
        TValue Spawn(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6);

#if UNITASK_PLUGIN
        UniTask<TValue>
#else
        Task<TValue>
#endif
        SpawnAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6) => Task.FromResult(Spawn(param1, param2, param3, param4, param5, param6));
    }

    public interface IMemoryPool<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, TValue> : IDespawnableMemoryPool<TValue>
    {
        TValue Spawn(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7);

#if UNITASK_PLUGIN
        UniTask<TValue>
#else
        Task<TValue>
#endif
        SpawnAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7) => Task.FromResult(Spawn(param1, param2, param3, param4, param5, param6, param7));
    }

    public interface IMemoryPool<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, TValue> : IDespawnableMemoryPool<TValue>
    {
        TValue Spawn(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8);

#if UNITASK_PLUGIN
        UniTask<TValue>
#else
        Task<TValue>
#endif
        SpawnAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8) => Task.FromResult(Spawn(param1, param2, param3, param4, param5, param6, param7, param8));
    }

    public interface IMemoryPool<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, in TParam9, TValue> : IDespawnableMemoryPool<TValue>
    {
        TValue Spawn(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9);

#if UNITASK_PLUGIN
        UniTask<TValue>
#else
        Task<TValue>
#endif
        SpawnAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9) => Task.FromResult(Spawn(param1, param2, param3, param4, param5, param6, param7, param8, param9));
    }

    public interface IMemoryPool<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, in TParam9, in TParam10, TValue> : IDespawnableMemoryPool<TValue>
    {
        TValue Spawn(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9, TParam10 param10);

#if UNITASK_PLUGIN
        UniTask<TValue>
#else
        Task<TValue>
#endif
        SpawnAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9, TParam10 param10) => Task.FromResult(Spawn(param1, param2, param3, param4, param5, param6, param7, param8, param9, param10));
    }

}