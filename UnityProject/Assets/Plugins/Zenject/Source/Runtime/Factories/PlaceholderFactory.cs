using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Zenject.Internal;
#if UNITASK_PLUGIN
using Cysharp.Threading.Tasks;
#else
using System.Threading.Tasks;
#endif

namespace Zenject
{
    public class PlaceholderFactory< TValue> : PlaceholderFactoryBase<TValue>, IFactory< TValue>
    {
        // Note: Most of the time you should not override this method and should instead
        // use BindFactory<>.FromIFactory if you want to do some custom logic
#if !NOT_UNITY3D
        [NotNull]
#endif
        public virtual TValue Create()
        {
            List<TypeValuePair> args = ZenPools.SpawnList<TypeValuePair>();
            try
            {
                return CreateInternal(args);
            }
            finally
            {
                ZenPools.DespawnList(args);
            }
        }

#if !NOT_UNITY3D
        [NotNull]
#endif
        public virtual async
#if UNITASK_PLUGIN
        UniTask<TValue>
#else
        Task<TValue>
#endif
        CreateAsync()
        {
            List<TypeValuePair> args = ListPool<TypeValuePair>.Instance.Spawn();
            try
            {
                return await CreateInternalAsync(args);
            }
            finally
            {
                ListPool<TypeValuePair>.Instance.Despawn(args);
            }
        }



        protected sealed override IEnumerable<Type> ParamTypes
        {
            get 
            { 
                yield break;
            }
        }
    }

    public class PlaceholderFactory<TParam1, TValue> : PlaceholderFactoryBase<TValue>, IFactory<TParam1, TValue>
    {
        // Note: Most of the time you should not override this method and should instead
        // use BindFactory<>.FromIFactory if you want to do some custom logic
#if !NOT_UNITY3D
        [NotNull]
#endif
        public virtual TValue Create(TParam1 param1)
        {
            List<TypeValuePair> args = ZenPools.SpawnList<TypeValuePair>();
            try
            {
                args.Add(InjectUtil.CreateTypePair(param1));
                return CreateInternal(args);
            }
            finally
            {
                ZenPools.DespawnList(args);
            }
        }

#if !NOT_UNITY3D
        [NotNull]
#endif
        public virtual async
#if UNITASK_PLUGIN
        UniTask<TValue>
#else
        Task<TValue>
#endif
        CreateAsync(TParam1 param1)
        {
            List<TypeValuePair> args = ListPool<TypeValuePair>.Instance.Spawn();
            try
            {
                args.Add(InjectUtil.CreateTypePair(param1));
                return await CreateInternalAsync(args);
            }
            finally
            {
                ListPool<TypeValuePair>.Instance.Despawn(args);
            }
        }



        protected sealed override IEnumerable<Type> ParamTypes
        {
            get 
            { 
                yield return typeof(TParam1);
            }
        }
    }

    public class PlaceholderFactory<TParam1, TParam2, TValue> : PlaceholderFactoryBase<TValue>, IFactory<TParam1, TParam2, TValue>
    {
        // Note: Most of the time you should not override this method and should instead
        // use BindFactory<>.FromIFactory if you want to do some custom logic
#if !NOT_UNITY3D
        [NotNull]
#endif
        public virtual TValue Create(TParam1 param1, TParam2 param2)
        {
            List<TypeValuePair> args = ZenPools.SpawnList<TypeValuePair>();
            try
            {
                args.Add(InjectUtil.CreateTypePair(param1));
                args.Add(InjectUtil.CreateTypePair(param2));
                return CreateInternal(args);
            }
            finally
            {
                ZenPools.DespawnList(args);
            }
        }

#if !NOT_UNITY3D
        [NotNull]
#endif
        public virtual async
#if UNITASK_PLUGIN
        UniTask<TValue>
#else
        Task<TValue>
#endif
        CreateAsync(TParam1 param1, TParam2 param2)
        {
            List<TypeValuePair> args = ListPool<TypeValuePair>.Instance.Spawn();
            try
            {
                args.Add(InjectUtil.CreateTypePair(param1));
                args.Add(InjectUtil.CreateTypePair(param2));
                return await CreateInternalAsync(args);
            }
            finally
            {
                ListPool<TypeValuePair>.Instance.Despawn(args);
            }
        }



        protected sealed override IEnumerable<Type> ParamTypes
        {
            get 
            { 
                yield return typeof(TParam1);
                yield return typeof(TParam2);
            }
        }
    }

    public class PlaceholderFactory<TParam1, TParam2, TParam3, TValue> : PlaceholderFactoryBase<TValue>, IFactory<TParam1, TParam2, TParam3, TValue>
    {
        // Note: Most of the time you should not override this method and should instead
        // use BindFactory<>.FromIFactory if you want to do some custom logic
#if !NOT_UNITY3D
        [NotNull]
#endif
        public virtual TValue Create(TParam1 param1, TParam2 param2, TParam3 param3)
        {
            List<TypeValuePair> args = ZenPools.SpawnList<TypeValuePair>();
            try
            {
                args.Add(InjectUtil.CreateTypePair(param1));
                args.Add(InjectUtil.CreateTypePair(param2));
                args.Add(InjectUtil.CreateTypePair(param3));
                return CreateInternal(args);
            }
            finally
            {
                ZenPools.DespawnList(args);
            }
        }

#if !NOT_UNITY3D
        [NotNull]
#endif
        public virtual async
#if UNITASK_PLUGIN
        UniTask<TValue>
#else
        Task<TValue>
#endif
        CreateAsync(TParam1 param1, TParam2 param2, TParam3 param3)
        {
            List<TypeValuePair> args = ListPool<TypeValuePair>.Instance.Spawn();
            try
            {
                args.Add(InjectUtil.CreateTypePair(param1));
                args.Add(InjectUtil.CreateTypePair(param2));
                args.Add(InjectUtil.CreateTypePair(param3));
                return await CreateInternalAsync(args);
            }
            finally
            {
                ListPool<TypeValuePair>.Instance.Despawn(args);
            }
        }



        protected sealed override IEnumerable<Type> ParamTypes
        {
            get 
            { 
                yield return typeof(TParam1);
                yield return typeof(TParam2);
                yield return typeof(TParam3);
            }
        }
    }

    public class PlaceholderFactory<TParam1, TParam2, TParam3, TParam4, TValue> : PlaceholderFactoryBase<TValue>, IFactory<TParam1, TParam2, TParam3, TParam4, TValue>
    {
        // Note: Most of the time you should not override this method and should instead
        // use BindFactory<>.FromIFactory if you want to do some custom logic
#if !NOT_UNITY3D
        [NotNull]
#endif
        public virtual TValue Create(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4)
        {
            List<TypeValuePair> args = ZenPools.SpawnList<TypeValuePair>();
            try
            {
                args.Add(InjectUtil.CreateTypePair(param1));
                args.Add(InjectUtil.CreateTypePair(param2));
                args.Add(InjectUtil.CreateTypePair(param3));
                args.Add(InjectUtil.CreateTypePair(param4));
                return CreateInternal(args);
            }
            finally
            {
                ZenPools.DespawnList(args);
            }
        }

#if !NOT_UNITY3D
        [NotNull]
#endif
        public virtual async
#if UNITASK_PLUGIN
        UniTask<TValue>
#else
        Task<TValue>
#endif
        CreateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4)
        {
            List<TypeValuePair> args = ListPool<TypeValuePair>.Instance.Spawn();
            try
            {
                args.Add(InjectUtil.CreateTypePair(param1));
                args.Add(InjectUtil.CreateTypePair(param2));
                args.Add(InjectUtil.CreateTypePair(param3));
                args.Add(InjectUtil.CreateTypePair(param4));
                return await CreateInternalAsync(args);
            }
            finally
            {
                ListPool<TypeValuePair>.Instance.Despawn(args);
            }
        }



        protected sealed override IEnumerable<Type> ParamTypes
        {
            get 
            { 
                yield return typeof(TParam1);
                yield return typeof(TParam2);
                yield return typeof(TParam3);
                yield return typeof(TParam4);
            }
        }
    }

    public class PlaceholderFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TValue> : PlaceholderFactoryBase<TValue>, IFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TValue>
    {
        // Note: Most of the time you should not override this method and should instead
        // use BindFactory<>.FromIFactory if you want to do some custom logic
#if !NOT_UNITY3D
        [NotNull]
#endif
        public virtual TValue Create(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5)
        {
            List<TypeValuePair> args = ZenPools.SpawnList<TypeValuePair>();
            try
            {
                args.Add(InjectUtil.CreateTypePair(param1));
                args.Add(InjectUtil.CreateTypePair(param2));
                args.Add(InjectUtil.CreateTypePair(param3));
                args.Add(InjectUtil.CreateTypePair(param4));
                args.Add(InjectUtil.CreateTypePair(param5));
                return CreateInternal(args);
            }
            finally
            {
                ZenPools.DespawnList(args);
            }
        }

#if !NOT_UNITY3D
        [NotNull]
#endif
        public virtual async
#if UNITASK_PLUGIN
        UniTask<TValue>
#else
        Task<TValue>
#endif
        CreateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5)
        {
            List<TypeValuePair> args = ListPool<TypeValuePair>.Instance.Spawn();
            try
            {
                args.Add(InjectUtil.CreateTypePair(param1));
                args.Add(InjectUtil.CreateTypePair(param2));
                args.Add(InjectUtil.CreateTypePair(param3));
                args.Add(InjectUtil.CreateTypePair(param4));
                args.Add(InjectUtil.CreateTypePair(param5));
                return await CreateInternalAsync(args);
            }
            finally
            {
                ListPool<TypeValuePair>.Instance.Despawn(args);
            }
        }



        protected sealed override IEnumerable<Type> ParamTypes
        {
            get 
            { 
                yield return typeof(TParam1);
                yield return typeof(TParam2);
                yield return typeof(TParam3);
                yield return typeof(TParam4);
                yield return typeof(TParam5);
            }
        }
    }

    public class PlaceholderFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TValue> : PlaceholderFactoryBase<TValue>, IFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TValue>
    {
        // Note: Most of the time you should not override this method and should instead
        // use BindFactory<>.FromIFactory if you want to do some custom logic
#if !NOT_UNITY3D
        [NotNull]
#endif
        public virtual TValue Create(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6)
        {
            List<TypeValuePair> args = ZenPools.SpawnList<TypeValuePair>();
            try
            {
                args.Add(InjectUtil.CreateTypePair(param1));
                args.Add(InjectUtil.CreateTypePair(param2));
                args.Add(InjectUtil.CreateTypePair(param3));
                args.Add(InjectUtil.CreateTypePair(param4));
                args.Add(InjectUtil.CreateTypePair(param5));
                args.Add(InjectUtil.CreateTypePair(param6));
                return CreateInternal(args);
            }
            finally
            {
                ZenPools.DespawnList(args);
            }
        }

#if !NOT_UNITY3D
        [NotNull]
#endif
        public virtual async
#if UNITASK_PLUGIN
        UniTask<TValue>
#else
        Task<TValue>
#endif
        CreateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6)
        {
            List<TypeValuePair> args = ListPool<TypeValuePair>.Instance.Spawn();
            try
            {
                args.Add(InjectUtil.CreateTypePair(param1));
                args.Add(InjectUtil.CreateTypePair(param2));
                args.Add(InjectUtil.CreateTypePair(param3));
                args.Add(InjectUtil.CreateTypePair(param4));
                args.Add(InjectUtil.CreateTypePair(param5));
                args.Add(InjectUtil.CreateTypePair(param6));
                return await CreateInternalAsync(args);
            }
            finally
            {
                ListPool<TypeValuePair>.Instance.Despawn(args);
            }
        }



        protected sealed override IEnumerable<Type> ParamTypes
        {
            get 
            { 
                yield return typeof(TParam1);
                yield return typeof(TParam2);
                yield return typeof(TParam3);
                yield return typeof(TParam4);
                yield return typeof(TParam5);
                yield return typeof(TParam6);
            }
        }
    }

    public class PlaceholderFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TValue> : PlaceholderFactoryBase<TValue>, IFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TValue>
    {
        // Note: Most of the time you should not override this method and should instead
        // use BindFactory<>.FromIFactory if you want to do some custom logic
#if !NOT_UNITY3D
        [NotNull]
#endif
        public virtual TValue Create(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7)
        {
            List<TypeValuePair> args = ZenPools.SpawnList<TypeValuePair>();
            try
            {
                args.Add(InjectUtil.CreateTypePair(param1));
                args.Add(InjectUtil.CreateTypePair(param2));
                args.Add(InjectUtil.CreateTypePair(param3));
                args.Add(InjectUtil.CreateTypePair(param4));
                args.Add(InjectUtil.CreateTypePair(param5));
                args.Add(InjectUtil.CreateTypePair(param6));
                args.Add(InjectUtil.CreateTypePair(param7));
                return CreateInternal(args);
            }
            finally
            {
                ZenPools.DespawnList(args);
            }
        }

#if !NOT_UNITY3D
        [NotNull]
#endif
        public virtual async
#if UNITASK_PLUGIN
        UniTask<TValue>
#else
        Task<TValue>
#endif
        CreateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7)
        {
            List<TypeValuePair> args = ListPool<TypeValuePair>.Instance.Spawn();
            try
            {
                args.Add(InjectUtil.CreateTypePair(param1));
                args.Add(InjectUtil.CreateTypePair(param2));
                args.Add(InjectUtil.CreateTypePair(param3));
                args.Add(InjectUtil.CreateTypePair(param4));
                args.Add(InjectUtil.CreateTypePair(param5));
                args.Add(InjectUtil.CreateTypePair(param6));
                args.Add(InjectUtil.CreateTypePair(param7));
                return await CreateInternalAsync(args);
            }
            finally
            {
                ListPool<TypeValuePair>.Instance.Despawn(args);
            }
        }



        protected sealed override IEnumerable<Type> ParamTypes
        {
            get 
            { 
                yield return typeof(TParam1);
                yield return typeof(TParam2);
                yield return typeof(TParam3);
                yield return typeof(TParam4);
                yield return typeof(TParam5);
                yield return typeof(TParam6);
                yield return typeof(TParam7);
            }
        }
    }

    public class PlaceholderFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TValue> : PlaceholderFactoryBase<TValue>, IFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TValue>
    {
        // Note: Most of the time you should not override this method and should instead
        // use BindFactory<>.FromIFactory if you want to do some custom logic
#if !NOT_UNITY3D
        [NotNull]
#endif
        public virtual TValue Create(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8)
        {
            List<TypeValuePair> args = ZenPools.SpawnList<TypeValuePair>();
            try
            {
                args.Add(InjectUtil.CreateTypePair(param1));
                args.Add(InjectUtil.CreateTypePair(param2));
                args.Add(InjectUtil.CreateTypePair(param3));
                args.Add(InjectUtil.CreateTypePair(param4));
                args.Add(InjectUtil.CreateTypePair(param5));
                args.Add(InjectUtil.CreateTypePair(param6));
                args.Add(InjectUtil.CreateTypePair(param7));
                args.Add(InjectUtil.CreateTypePair(param8));
                return CreateInternal(args);
            }
            finally
            {
                ZenPools.DespawnList(args);
            }
        }

#if !NOT_UNITY3D
        [NotNull]
#endif
        public virtual async
#if UNITASK_PLUGIN
        UniTask<TValue>
#else
        Task<TValue>
#endif
        CreateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8)
        {
            List<TypeValuePair> args = ListPool<TypeValuePair>.Instance.Spawn();
            try
            {
                args.Add(InjectUtil.CreateTypePair(param1));
                args.Add(InjectUtil.CreateTypePair(param2));
                args.Add(InjectUtil.CreateTypePair(param3));
                args.Add(InjectUtil.CreateTypePair(param4));
                args.Add(InjectUtil.CreateTypePair(param5));
                args.Add(InjectUtil.CreateTypePair(param6));
                args.Add(InjectUtil.CreateTypePair(param7));
                args.Add(InjectUtil.CreateTypePair(param8));
                return await CreateInternalAsync(args);
            }
            finally
            {
                ListPool<TypeValuePair>.Instance.Despawn(args);
            }
        }



        protected sealed override IEnumerable<Type> ParamTypes
        {
            get 
            { 
                yield return typeof(TParam1);
                yield return typeof(TParam2);
                yield return typeof(TParam3);
                yield return typeof(TParam4);
                yield return typeof(TParam5);
                yield return typeof(TParam6);
                yield return typeof(TParam7);
                yield return typeof(TParam8);
            }
        }
    }

    public class PlaceholderFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TValue> : PlaceholderFactoryBase<TValue>, IFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TValue>
    {
        // Note: Most of the time you should not override this method and should instead
        // use BindFactory<>.FromIFactory if you want to do some custom logic
#if !NOT_UNITY3D
        [NotNull]
#endif
        public virtual TValue Create(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9)
        {
            List<TypeValuePair> args = ZenPools.SpawnList<TypeValuePair>();
            try
            {
                args.Add(InjectUtil.CreateTypePair(param1));
                args.Add(InjectUtil.CreateTypePair(param2));
                args.Add(InjectUtil.CreateTypePair(param3));
                args.Add(InjectUtil.CreateTypePair(param4));
                args.Add(InjectUtil.CreateTypePair(param5));
                args.Add(InjectUtil.CreateTypePair(param6));
                args.Add(InjectUtil.CreateTypePair(param7));
                args.Add(InjectUtil.CreateTypePair(param8));
                args.Add(InjectUtil.CreateTypePair(param9));
                return CreateInternal(args);
            }
            finally
            {
                ZenPools.DespawnList(args);
            }
        }

#if !NOT_UNITY3D
        [NotNull]
#endif
        public virtual async
#if UNITASK_PLUGIN
        UniTask<TValue>
#else
        Task<TValue>
#endif
        CreateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9)
        {
            List<TypeValuePair> args = ListPool<TypeValuePair>.Instance.Spawn();
            try
            {
                args.Add(InjectUtil.CreateTypePair(param1));
                args.Add(InjectUtil.CreateTypePair(param2));
                args.Add(InjectUtil.CreateTypePair(param3));
                args.Add(InjectUtil.CreateTypePair(param4));
                args.Add(InjectUtil.CreateTypePair(param5));
                args.Add(InjectUtil.CreateTypePair(param6));
                args.Add(InjectUtil.CreateTypePair(param7));
                args.Add(InjectUtil.CreateTypePair(param8));
                args.Add(InjectUtil.CreateTypePair(param9));
                return await CreateInternalAsync(args);
            }
            finally
            {
                ListPool<TypeValuePair>.Instance.Despawn(args);
            }
        }



        protected sealed override IEnumerable<Type> ParamTypes
        {
            get 
            { 
                yield return typeof(TParam1);
                yield return typeof(TParam2);
                yield return typeof(TParam3);
                yield return typeof(TParam4);
                yield return typeof(TParam5);
                yield return typeof(TParam6);
                yield return typeof(TParam7);
                yield return typeof(TParam8);
                yield return typeof(TParam9);
            }
        }
    }

    public class PlaceholderFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TValue> : PlaceholderFactoryBase<TValue>, IFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TValue>
    {
        // Note: Most of the time you should not override this method and should instead
        // use BindFactory<>.FromIFactory if you want to do some custom logic
#if !NOT_UNITY3D
        [NotNull]
#endif
        public virtual TValue Create(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9, TParam10 param10)
        {
            List<TypeValuePair> args = ZenPools.SpawnList<TypeValuePair>();
            try
            {
                args.Add(InjectUtil.CreateTypePair(param1));
                args.Add(InjectUtil.CreateTypePair(param2));
                args.Add(InjectUtil.CreateTypePair(param3));
                args.Add(InjectUtil.CreateTypePair(param4));
                args.Add(InjectUtil.CreateTypePair(param5));
                args.Add(InjectUtil.CreateTypePair(param6));
                args.Add(InjectUtil.CreateTypePair(param7));
                args.Add(InjectUtil.CreateTypePair(param8));
                args.Add(InjectUtil.CreateTypePair(param9));
                args.Add(InjectUtil.CreateTypePair(param10));
                return CreateInternal(args);
            }
            finally
            {
                ZenPools.DespawnList(args);
            }
        }

#if !NOT_UNITY3D
        [NotNull]
#endif
        public virtual async
#if UNITASK_PLUGIN
        UniTask<TValue>
#else
        Task<TValue>
#endif
        CreateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9, TParam10 param10)
        {
            List<TypeValuePair> args = ListPool<TypeValuePair>.Instance.Spawn();
            try
            {
                args.Add(InjectUtil.CreateTypePair(param1));
                args.Add(InjectUtil.CreateTypePair(param2));
                args.Add(InjectUtil.CreateTypePair(param3));
                args.Add(InjectUtil.CreateTypePair(param4));
                args.Add(InjectUtil.CreateTypePair(param5));
                args.Add(InjectUtil.CreateTypePair(param6));
                args.Add(InjectUtil.CreateTypePair(param7));
                args.Add(InjectUtil.CreateTypePair(param8));
                args.Add(InjectUtil.CreateTypePair(param9));
                args.Add(InjectUtil.CreateTypePair(param10));
                return await CreateInternalAsync(args);
            }
            finally
            {
                ListPool<TypeValuePair>.Instance.Despawn(args);
            }
        }



        protected sealed override IEnumerable<Type> ParamTypes
        {
            get 
            { 
                yield return typeof(TParam1);
                yield return typeof(TParam2);
                yield return typeof(TParam3);
                yield return typeof(TParam4);
                yield return typeof(TParam5);
                yield return typeof(TParam6);
                yield return typeof(TParam7);
                yield return typeof(TParam8);
                yield return typeof(TParam9);
                yield return typeof(TParam10);
            }
        }
    }

}