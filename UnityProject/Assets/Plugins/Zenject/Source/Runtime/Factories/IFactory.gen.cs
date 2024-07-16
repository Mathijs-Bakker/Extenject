#if UNITASK_PLUGIN
using Cysharp.Threading.Tasks;
#else
using System.Threading.Tasks;
#endif

namespace Zenject
{
    public interface IFactory<TValue> : IFactory
    {
        TValue Create();

#if UNITASK_PLUGIN
        UniTask<TValue> CreateAsync() => UniTask.FromResult(Create());
#else
        Task<TValue> CreateAsync() => Task.FromResult(Create());
#endif
    }

    public interface IFactory<in TParam1,TValue> : IFactory
    {
        TValue Create(TParam1 param1);

#if UNITASK_PLUGIN
        UniTask<TValue> CreateAsync(TParam1 param1) => UniTask.FromResult(Create(param1));
#else
        Task<TValue> CreateAsync(TParam1 param1) => Task.FromResult(Create(param1));
#endif
    }

    public interface IFactory<in TParam1, in TParam2,TValue> : IFactory
    {
        TValue Create(TParam1 param1, TParam2 param2);

#if UNITASK_PLUGIN
        UniTask<TValue> CreateAsync(TParam1 param1, TParam2 param2) => UniTask.FromResult(Create(param1, param2));
#else
        Task<TValue> CreateAsync(TParam1 param1, TParam2 param2) => Task.FromResult(Create(param1, param2));
#endif
    }

    public interface IFactory<in TParam1, in TParam2, in TParam3,TValue> : IFactory
    {
        TValue Create(TParam1 param1, TParam2 param2, TParam3 param3);

#if UNITASK_PLUGIN
        UniTask<TValue> CreateAsync(TParam1 param1, TParam2 param2, TParam3 param3) => UniTask.FromResult(Create(param1, param2, param3));
#else
        Task<TValue> CreateAsync(TParam1 param1, TParam2 param2, TParam3 param3) => Task.FromResult(Create(param1, param2, param3));
#endif
    }

    public interface IFactory<in TParam1, in TParam2, in TParam3, in TParam4,TValue> : IFactory
    {
        TValue Create(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4);

#if UNITASK_PLUGIN
        UniTask<TValue> CreateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4) => UniTask.FromResult(Create(param1, param2, param3, param4));
#else
        Task<TValue> CreateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4) => Task.FromResult(Create(param1, param2, param3, param4));
#endif
    }

    public interface IFactory<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5,TValue> : IFactory
    {
        TValue Create(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5);

#if UNITASK_PLUGIN
        UniTask<TValue> CreateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5) => UniTask.FromResult(Create(param1, param2, param3, param4, param5));
#else
        Task<TValue> CreateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5) => Task.FromResult(Create(param1, param2, param3, param4, param5));
#endif
    }

    public interface IFactory<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6,TValue> : IFactory
    {
        TValue Create(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6);

#if UNITASK_PLUGIN
        UniTask<TValue> CreateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6) => UniTask.FromResult(Create(param1, param2, param3, param4, param5, param6));
#else
        Task<TValue> CreateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6) => Task.FromResult(Create(param1, param2, param3, param4, param5, param6));
#endif
    }

    public interface IFactory<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7,TValue> : IFactory
    {
        TValue Create(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7);

#if UNITASK_PLUGIN
        UniTask<TValue> CreateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7) => UniTask.FromResult(Create(param1, param2, param3, param4, param5, param6, param7));
#else
        Task<TValue> CreateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7) => Task.FromResult(Create(param1, param2, param3, param4, param5, param6, param7));
#endif
    }

    public interface IFactory<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8,TValue> : IFactory
    {
        TValue Create(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8);

#if UNITASK_PLUGIN
        UniTask<TValue> CreateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8) => UniTask.FromResult(Create(param1, param2, param3, param4, param5, param6, param7, param8));
#else
        Task<TValue> CreateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8) => Task.FromResult(Create(param1, param2, param3, param4, param5, param6, param7, param8));
#endif
    }

    public interface IFactory<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, in TParam9,TValue> : IFactory
    {
        TValue Create(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9);

#if UNITASK_PLUGIN
        UniTask<TValue> CreateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9) => UniTask.FromResult(Create(param1, param2, param3, param4, param5, param6, param7, param8, param9));
#else
        Task<TValue> CreateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9) => Task.FromResult(Create(param1, param2, param3, param4, param5, param6, param7, param8, param9));
#endif
    }

    public interface IFactory<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, in TParam9, in TParam10,TValue> : IFactory
    {
        TValue Create(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9, TParam10 param10);

#if UNITASK_PLUGIN
        UniTask<TValue> CreateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9, TParam10 param10) => UniTask.FromResult(Create(param1, param2, param3, param4, param5, param6, param7, param8, param9, param10));
#else
        Task<TValue> CreateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9, TParam10 param10) => Task.FromResult(Create(param1, param2, param3, param4, param5, param6, param7, param8, param9, param10));
#endif
    }

}