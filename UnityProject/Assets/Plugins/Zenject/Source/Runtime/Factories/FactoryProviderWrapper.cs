using ModestTree;

#if UNITASK_PLUGIN
using Cysharp.Threading.Tasks;
#else
using System.Threading.Tasks;
#endif

namespace Zenject
{
    public class FactoryProviderWrapper<TContract> : IFactory<TContract>
    {
        readonly IProvider _provider;
        readonly InjectContext _injectContext;

        public FactoryProviderWrapper(
            IProvider provider, InjectContext injectContext)
        {
            Assert.That(injectContext.MemberType.DerivesFromOrEqual<TContract>());

            _provider = provider;
            _injectContext = injectContext;
            IsAsync = _provider.IsAsync;
        }

        public bool IsAsync { get; }

        public TContract Create()
        {
            Assert.That(!IsAsync);
            
            var instance = _provider.GetInstance(_injectContext);

            if (_injectContext.Container.IsValidating)
            {
                // During validation it is sufficient to just call the _provider.GetInstance
                return default(TContract);
            }

            Assert.That(instance == null || instance.GetType().DerivesFromOrEqual(_injectContext.MemberType));

            return (TContract) instance;
        }

        public async
#if UNITASK_PLUGIN
            UniTask<TContract>
#else
            Task<TContract>
#endif
            CreateAsync()
        {
            var instance = _provider.GetInstance(_injectContext);

            if (_injectContext.Container.IsValidating)
            {
                // During validation it is sufficient to just call the _provider.GetInstance
                return default(TContract);
            }

            if (instance is IAsyncInject asyncInject)
            {
                await asyncInject.Task;
                instance = asyncInject.Result;
            }

            Assert.That(instance == null
                        || instance.GetType().DerivesFromOrEqual(_injectContext.MemberType));

            return (TContract) instance;
        }
    }
}