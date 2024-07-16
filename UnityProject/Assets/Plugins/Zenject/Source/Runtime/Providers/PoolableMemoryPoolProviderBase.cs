using System;
using System.Collections.Generic;

namespace Zenject
{
    public abstract class PoolableMemoryPoolProviderBase<TContract> : IProvider
    {
        public PoolableMemoryPoolProviderBase(
            DiContainer container, Guid poolId)
        {
            Container = container;
            PoolId = poolId;
        }

        public abstract bool IsAsync { get; }

        public bool IsCached
        {
            get { return false; }
        }

        protected Guid PoolId
        {
            get;
            private set;
        }

        protected DiContainer Container
        {
            get;
            private set;
        }

        public bool TypeVariesBasedOnMemberType
        {
            get { return false; }
        }

        public Type GetInstanceType(InjectContext context)
        {
            return typeof(TContract);
        }

        public abstract void GetAllInstancesWithInjectSplit(
            InjectContext context, List<TypeValuePair> args, out Action injectAction, List<object> buffer);
    }
}