using System;
using System.Collections.Generic;
using System.Threading;
using ModestTree;

#if UNITASK_PLUGIN
using Cysharp.Threading.Tasks;
#else
using System.Threading.Tasks;
#endif


namespace Zenject
{
#if UNITASK_PLUGIN
        public delegate UniTask<T> AsyncMethodDelegate<T>();
        public delegate UniTask<T> AsyncCancellableMethodDelegate<T>(CancellationToken ct);
#else
        public delegate Task<T> AsyncMethodDelegate<T>();
        public delegate Task<T> AsyncCancellableMethodDelegate<T>(CancellationToken ct);
#endif
    
    [NoReflectionBaking]
    public class AsyncMethodProviderSimple<TContract, TConcrete> : IProvider where TConcrete : TContract
    {
        readonly AsyncMethodDelegate<TConcrete> _method;
        readonly AsyncCancellableMethodDelegate<TConcrete> _methodCancellable;

        public AsyncMethodProviderSimple(AsyncMethodDelegate<TConcrete> method)
        {
            _method = method;
        }

        public AsyncMethodProviderSimple(AsyncCancellableMethodDelegate<TConcrete> method)
        {
            _methodCancellable = method;
        }

        public bool TypeVariesBasedOnMemberType => false;
        public bool IsCached => false;
        public Type GetInstanceType(InjectContext context) => typeof(TConcrete);

        public void GetAllInstancesWithInjectSplit(InjectContext context, List<TypeValuePair> args, out Action injectAction, List<object> buffer)
        {
            Assert.IsEmpty(args);
            Assert.IsNotNull(context);

            injectAction = null;

            AsyncInject<TContract>.AsyncCreationMethod typeCastAsyncCall = null;
            if (_methodCancellable != null)
            {
                typeCastAsyncCall = async (_, _, ct) =>
                {
                    var task = _methodCancellable(ct);
                    return await task;
                    // return task.Result;
                };
            }
            else if (_method != null)
            {
                typeCastAsyncCall = async (_, _, _) =>
                {
                    var task = _method();
                    return await task;
                    // return task.Result;
                };
            }

            Assert.IsNotNull(typeCastAsyncCall);

            var asyncInject = new AsyncInject<TContract>(context, args, typeCastAsyncCall);

            buffer.Add(asyncInject);
        }
    }
}