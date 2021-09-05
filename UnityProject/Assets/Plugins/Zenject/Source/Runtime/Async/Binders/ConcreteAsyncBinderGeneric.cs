using System;
using System.Collections.Generic;
using System.Linq;
using ModestTree;

namespace Zenject
{
    [NoReflectionBaking]
    public class ConcreteAsyncBinderGeneric<TContract> : AsyncFromBinderGeneric<TContract, TContract>
    {
        public ConcreteAsyncBinderGeneric(
            DiContainer bindContainer, BindInfo bindInfo,
            BindStatement bindStatement)
            : base(bindContainer, bindInfo, bindStatement)
        {
            bindInfo.ToChoice = ToChoices.Self;
        }

        public AsyncFromBinderGeneric<TContract, TConcrete> To<TConcrete>()
            where TConcrete : TContract
        {
            return new AsyncFromBinderGeneric<TContract, TConcrete>(
                BindContainer, BindInfo, BindStatement);
        }
    }
}