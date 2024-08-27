using System;

namespace Zenject
{
    public interface IMemoryPool
    {
        bool IsAsync => false;
        
        int NumTotal { get; }
        int NumActive { get; }
        int NumInactive { get; }

        Type ItemType
        {
            get;
        }

        /// <summary>
        /// Changes pool size by creating new elements or destroying existing elements
        /// This bypasses the configured expansion method (OneAtATime or Doubling)
        /// </summary>
        void Resize(int desiredPoolSize);

        void Clear();

        /// <summary>
        /// Expands the pool by the additional size.
        /// This bypasses the configured expansion method (OneAtATime or Doubling)
        /// </summary>
        /// <param name="numToAdd">The additional number of items to allocate in the pool</param>
        void ExpandBy(int numToAdd);

        /// <summary>
        /// Shrinks the MemoryPool by removing a given number of elements
        /// This bypasses the configured expansion method (OneAtATime or Doubling)
        /// </summary>
        /// <param name="numToRemove">The amount of items to remove from the pool</param>
        void ShrinkBy(int numToRemove);

        void Despawn(object obj);
    }

    public interface IDespawnableMemoryPool<TValue> : IMemoryPool
    {
        void Despawn(TValue item);
    }
}
