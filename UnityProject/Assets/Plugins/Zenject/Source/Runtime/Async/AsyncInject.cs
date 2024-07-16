using System;
using System.Threading;
using ModestTree;
using System.Collections.Generic;

#if UNITASK_PLUGIN
using Cysharp.Threading.Tasks;
using Task = Cysharp.Threading.Tasks.UniTask;
#else
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Task = System.Threading.Tasks.Task;
#endif

namespace Zenject
{
    public interface IAsyncInject
    {
        bool HasResult { get; }
        bool IsCancelled { get; }
        bool IsFaulted { get; }
        bool IsCompleted { get; }
        object Result { get; }

        Task Task { get; }

#if !UNITASK_PLUGIN
        TaskAwaiter GetAwaiter();
#endif
    }


    [ZenjectAllowDuringValidation]
    [NoReflectionBaking]
    public class AsyncInject<T> : IAsyncInject
    {
#if UNITASK_PLUGIN
        public delegate UniTask<T> AsyncCreationMethod(InjectContext context, List<TypeValuePair> args, CancellationToken cancellationToken);
#else
        public delegate Task<T> AsyncCreationMethod(InjectContext context, List<TypeValuePair> args, CancellationToken cancellationToken);
#endif

        protected readonly CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();
        protected readonly InjectContext _context;
        protected readonly List<TypeValuePair> _args;

        public event Action<T> Completed;
        public event Action<AggregateException> Faulted;
        public event Action Cancelled;

        public bool HasResult { get; protected set; }
        public bool IsSuccessful { get; protected set; }
        public bool IsCancelled { get; protected set; }
        public bool IsFaulted { get; protected set; }

        public bool IsCompleted => IsSuccessful || IsCancelled || IsFaulted;

        object IAsyncInject.Result => Result;
        public Task Task { get; }

        T _result;

#if !UNITASK_PLUGIN
        private Task<T> _loadResultTask;
#endif

        protected AsyncInject(InjectContext context)
        {
            _context = context;
        }

        public AsyncInject(InjectContext context, List<TypeValuePair> args, AsyncCreationMethod asyncMethod)
        {
            _args = args;
            _context = context;

            Task = StartAsync(asyncMethod, _cancellationTokenSource.Token);
        }

        public void Cancel()
        {
            _cancellationTokenSource.Cancel();
        }

        protected async Task StartAsync(AsyncCreationMethod asyncMethod, CancellationToken token)
        {
            try
            {
#if UNITASK_PLUGIN
                T result = await asyncMethod(_context, _args, token);
#else
                T result = await (_loadResultTask = asyncMethod(_context, _args, token));
#endif
                HandleCompleted(result);
            }
            catch (OperationCanceledException)
            {
                HandleCancelled();
                throw;
            }
            catch (AggregateException e)
            {
                HandleFaulted(e);
                throw;
            }
            catch (Exception e)
            {
                HandleFaulted(new AggregateException(e));
                throw;
            }
        }

        private void HandleCompleted(T result)
        {
            _result = result;
            HasResult = !result.Equals(default(T));
            IsSuccessful = true;
            Completed?.Invoke(result);
        }

        private void HandleCancelled()
        {
            IsCancelled = true;
            Cancelled?.Invoke();
        }

        private void HandleFaulted(AggregateException exception)
        {
            IsFaulted = true;
            Faulted?.Invoke(exception);
        }

        public bool TryGetResult(out T result)
        {
            if (HasResult)
            {
                result = _result;
                return true;
            }

            result = default;
            return false;
        }

        public T Result
        {
            get
            {
                Assert.That(HasResult, "AsyncInject does not have a result.  ");
                return _result;
            }
        }

#if !UNITASK_PLUGIN
        TaskAwaiter IAsyncInject.GetAwaiter() => ((Task) _loadResultTask).GetAwaiter();
        public TaskAwaiter<T> GetAwaiter() => _loadResultTask.GetAwaiter();
#endif
    }
}