using System;
using System.Collections.Generic;
using System.Linq;
using ModestTree;
using UnityEngine;

#if UNITASK_PLUGIN
using Cysharp.Threading.Tasks;
#else
using System.Threading.Tasks;
#endif

namespace Zenject
{
    public interface IPlaceholderFactory : IValidatable
    {
    }

    // Placeholder factories can be used to choose a creation method in an installer, using FactoryBinder
    public abstract class PlaceholderFactoryBase<TValue> : IPlaceholderFactory
    {
        IProvider _provider;
        InjectContext _injectContext;
        readonly List<TypeValuePair> _emptyList = new();

        public bool IsAsync { get; private set; }
        
        [Inject]
        void Construct(IProvider provider, InjectContext injectContext)
        {
            Assert.IsNotNull(provider);
            Assert.IsNotNull(injectContext);

            _provider = provider;
            _injectContext = injectContext;
            IsAsync = _provider.IsAsync;
        }

        protected TValue CreateInternal(List<TypeValuePair> extraArgs)
        {
            if (IsAsync)
                throw new ZenjectException("[Zenject] Factory is bound with async provider. Call CreateAsync instead of Create");
            
            try
            {
                object result = _provider.GetInstance(_injectContext, extraArgs ?? _emptyList);

                if (_injectContext.Container.IsValidating && result is ValidationMarker)
                {
                    return default(TValue);
                }

                Assert.That(result == null || result.GetType().DerivesFromOrEqual<TValue>());

                return (TValue) result;
            }
            catch (Exception e)
            {
                throw new ZenjectException(
                    "Error during construction of type '{0}' via {1}.Create method!".Fmt(typeof(TValue), GetType()), e);
            }
        }

        protected async
#if UNITASK_PLUGIN
            UniTask<TValue>
#else
            Task<TValue>
#endif
            CreateInternalAsync(List<TypeValuePair> extraArgs)
        {
            try
            {
                object result = _provider.GetInstance(_injectContext, extraArgs ?? _emptyList);

                if (_injectContext.Container.IsValidating && result is ValidationMarker)
                {
                    return default(TValue);
                }

                Assert.That(result == null || result.GetType().DerivesFromOrEqual<IAsyncInject>());
                
                if (result is IAsyncInject asyncInject)
                {
                    await asyncInject.Task;
                    result = asyncInject.Result;
                }

                Assert.That(result == null || result.GetType().DerivesFromOrEqual<TValue>());

                return (TValue) result;
            }
            catch (Exception e)
            {
                throw new ZenjectException(
                    "Error during construction of type '{0}' via {1}.Create method!".Fmt(typeof(TValue), GetType()), e);
            }
        }

        public virtual void Validate()
        {
            _provider.GetInstance(
                _injectContext, ValidationUtil.CreateDefaultArgs(ParamTypes.ToArray()));
        }

        protected abstract IEnumerable<Type> ParamTypes
        {
            get;
        }
    }
}
