using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

namespace Zenject
{
    // NOTE: For this to work, the given component must be at the root game object of the thing
    // you want to use in a pool
    public class MonoMemoryPoolAsync<TValue>
        : MemoryPoolAsync<TValue>
        where TValue : Component
    {
        Transform _originalParent;

        [Inject]
        public MonoMemoryPoolAsync()
        {
        }

        protected override void OnCreated(TValue item)
        {
            item.gameObject.SetActive(false);
            // Record the original parent which will be set to whatever is used in the UnderTransform method
            _originalParent = item.transform.parent;
        }

        protected override void OnDestroyed(TValue item)
        {
            GameObject.Destroy(item.gameObject);
        }

        protected override void OnSpawned(TValue item)
        {
            item.gameObject.SetActive(true);
        }

        protected override void OnDespawned(TValue item)
        {
            item.gameObject.SetActive(false);

            if (item.transform.parent != _originalParent)
            {
                item.transform.SetParent(_originalParent, false);
            }
        }
    }

    // NOTE: For this to work, the given component must be at the root game object of the thing
    // you want to use in a pool
    public class MonoMemoryPoolAsync<TParam1,TValue>
        : MemoryPoolAsync<TParam1,TValue>
        where TValue : Component
    {
        Transform _originalParent;

        [Inject]
        public MonoMemoryPoolAsync()
        {
        }

        protected override void OnCreated(TValue item)
        {
            item.gameObject.SetActive(false);
            // Record the original parent which will be set to whatever is used in the UnderTransform method
            _originalParent = item.transform.parent;
        }

        protected override void OnDestroyed(TValue item)
        {
            GameObject.Destroy(item.gameObject);
        }

        protected override void OnSpawned(TValue item)
        {
            item.gameObject.SetActive(true);
        }

        protected override void OnDespawned(TValue item)
        {
            item.gameObject.SetActive(false);

            if (item.transform.parent != _originalParent)
            {
                item.transform.SetParent(_originalParent, false);
            }
        }
    }

    // NOTE: For this to work, the given component must be at the root game object of the thing
    // you want to use in a pool
    public class MonoMemoryPoolAsync<TParam1, TParam2,TValue>
        : MemoryPoolAsync<TParam1, TParam2,TValue>
        where TValue : Component
    {
        Transform _originalParent;

        [Inject]
        public MonoMemoryPoolAsync()
        {
        }

        protected override void OnCreated(TValue item)
        {
            item.gameObject.SetActive(false);
            // Record the original parent which will be set to whatever is used in the UnderTransform method
            _originalParent = item.transform.parent;
        }

        protected override void OnDestroyed(TValue item)
        {
            GameObject.Destroy(item.gameObject);
        }

        protected override void OnSpawned(TValue item)
        {
            item.gameObject.SetActive(true);
        }

        protected override void OnDespawned(TValue item)
        {
            item.gameObject.SetActive(false);

            if (item.transform.parent != _originalParent)
            {
                item.transform.SetParent(_originalParent, false);
            }
        }
    }

    // NOTE: For this to work, the given component must be at the root game object of the thing
    // you want to use in a pool
    public class MonoMemoryPoolAsync<TParam1, TParam2, TParam3,TValue>
        : MemoryPoolAsync<TParam1, TParam2, TParam3,TValue>
        where TValue : Component
    {
        Transform _originalParent;

        [Inject]
        public MonoMemoryPoolAsync()
        {
        }

        protected override void OnCreated(TValue item)
        {
            item.gameObject.SetActive(false);
            // Record the original parent which will be set to whatever is used in the UnderTransform method
            _originalParent = item.transform.parent;
        }

        protected override void OnDestroyed(TValue item)
        {
            GameObject.Destroy(item.gameObject);
        }

        protected override void OnSpawned(TValue item)
        {
            item.gameObject.SetActive(true);
        }

        protected override void OnDespawned(TValue item)
        {
            item.gameObject.SetActive(false);

            if (item.transform.parent != _originalParent)
            {
                item.transform.SetParent(_originalParent, false);
            }
        }
    }

    // NOTE: For this to work, the given component must be at the root game object of the thing
    // you want to use in a pool
    public class MonoMemoryPoolAsync<TParam1, TParam2, TParam3, TParam4,TValue>
        : MemoryPoolAsync<TParam1, TParam2, TParam3, TParam4,TValue>
        where TValue : Component
    {
        Transform _originalParent;

        [Inject]
        public MonoMemoryPoolAsync()
        {
        }

        protected override void OnCreated(TValue item)
        {
            item.gameObject.SetActive(false);
            // Record the original parent which will be set to whatever is used in the UnderTransform method
            _originalParent = item.transform.parent;
        }

        protected override void OnDestroyed(TValue item)
        {
            GameObject.Destroy(item.gameObject);
        }

        protected override void OnSpawned(TValue item)
        {
            item.gameObject.SetActive(true);
        }

        protected override void OnDespawned(TValue item)
        {
            item.gameObject.SetActive(false);

            if (item.transform.parent != _originalParent)
            {
                item.transform.SetParent(_originalParent, false);
            }
        }
    }

    // NOTE: For this to work, the given component must be at the root game object of the thing
    // you want to use in a pool
    public class MonoMemoryPoolAsync<TParam1, TParam2, TParam3, TParam4, TParam5,TValue>
        : MemoryPoolAsync<TParam1, TParam2, TParam3, TParam4, TParam5,TValue>
        where TValue : Component
    {
        Transform _originalParent;

        [Inject]
        public MonoMemoryPoolAsync()
        {
        }

        protected override void OnCreated(TValue item)
        {
            item.gameObject.SetActive(false);
            // Record the original parent which will be set to whatever is used in the UnderTransform method
            _originalParent = item.transform.parent;
        }

        protected override void OnDestroyed(TValue item)
        {
            GameObject.Destroy(item.gameObject);
        }

        protected override void OnSpawned(TValue item)
        {
            item.gameObject.SetActive(true);
        }

        protected override void OnDespawned(TValue item)
        {
            item.gameObject.SetActive(false);

            if (item.transform.parent != _originalParent)
            {
                item.transform.SetParent(_originalParent, false);
            }
        }
    }

    // NOTE: For this to work, the given component must be at the root game object of the thing
    // you want to use in a pool
    public class MonoMemoryPoolAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6,TValue>
        : MemoryPoolAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6,TValue>
        where TValue : Component
    {
        Transform _originalParent;

        [Inject]
        public MonoMemoryPoolAsync()
        {
        }

        protected override void OnCreated(TValue item)
        {
            item.gameObject.SetActive(false);
            // Record the original parent which will be set to whatever is used in the UnderTransform method
            _originalParent = item.transform.parent;
        }

        protected override void OnDestroyed(TValue item)
        {
            GameObject.Destroy(item.gameObject);
        }

        protected override void OnSpawned(TValue item)
        {
            item.gameObject.SetActive(true);
        }

        protected override void OnDespawned(TValue item)
        {
            item.gameObject.SetActive(false);

            if (item.transform.parent != _originalParent)
            {
                item.transform.SetParent(_originalParent, false);
            }
        }
    }

    // NOTE: For this to work, the given component must be at the root game object of the thing
    // you want to use in a pool
    public class MonoMemoryPoolAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7,TValue>
        : MemoryPoolAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7,TValue>
        where TValue : Component
    {
        Transform _originalParent;

        [Inject]
        public MonoMemoryPoolAsync()
        {
        }

        protected override void OnCreated(TValue item)
        {
            item.gameObject.SetActive(false);
            // Record the original parent which will be set to whatever is used in the UnderTransform method
            _originalParent = item.transform.parent;
        }

        protected override void OnDestroyed(TValue item)
        {
            GameObject.Destroy(item.gameObject);
        }

        protected override void OnSpawned(TValue item)
        {
            item.gameObject.SetActive(true);
        }

        protected override void OnDespawned(TValue item)
        {
            item.gameObject.SetActive(false);

            if (item.transform.parent != _originalParent)
            {
                item.transform.SetParent(_originalParent, false);
            }
        }
    }

    // NOTE: For this to work, the given component must be at the root game object of the thing
    // you want to use in a pool
    public class MonoMemoryPoolAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8,TValue>
        : MemoryPoolAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8,TValue>
        where TValue : Component
    {
        Transform _originalParent;

        [Inject]
        public MonoMemoryPoolAsync()
        {
        }

        protected override void OnCreated(TValue item)
        {
            item.gameObject.SetActive(false);
            // Record the original parent which will be set to whatever is used in the UnderTransform method
            _originalParent = item.transform.parent;
        }

        protected override void OnDestroyed(TValue item)
        {
            GameObject.Destroy(item.gameObject);
        }

        protected override void OnSpawned(TValue item)
        {
            item.gameObject.SetActive(true);
        }

        protected override void OnDespawned(TValue item)
        {
            item.gameObject.SetActive(false);

            if (item.transform.parent != _originalParent)
            {
                item.transform.SetParent(_originalParent, false);
            }
        }
    }

    // NOTE: For this to work, the given component must be at the root game object of the thing
    // you want to use in a pool
    public class MonoMemoryPoolAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9,TValue>
        : MemoryPoolAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9,TValue>
        where TValue : Component
    {
        Transform _originalParent;

        [Inject]
        public MonoMemoryPoolAsync()
        {
        }

        protected override void OnCreated(TValue item)
        {
            item.gameObject.SetActive(false);
            // Record the original parent which will be set to whatever is used in the UnderTransform method
            _originalParent = item.transform.parent;
        }

        protected override void OnDestroyed(TValue item)
        {
            GameObject.Destroy(item.gameObject);
        }

        protected override void OnSpawned(TValue item)
        {
            item.gameObject.SetActive(true);
        }

        protected override void OnDespawned(TValue item)
        {
            item.gameObject.SetActive(false);

            if (item.transform.parent != _originalParent)
            {
                item.transform.SetParent(_originalParent, false);
            }
        }
    }

    // NOTE: For this to work, the given component must be at the root game object of the thing
    // you want to use in a pool
    public class MonoMemoryPoolAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10,TValue>
        : MemoryPoolAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10,TValue>
        where TValue : Component
    {
        Transform _originalParent;

        [Inject]
        public MonoMemoryPoolAsync()
        {
        }

        protected override void OnCreated(TValue item)
        {
            item.gameObject.SetActive(false);
            // Record the original parent which will be set to whatever is used in the UnderTransform method
            _originalParent = item.transform.parent;
        }

        protected override void OnDestroyed(TValue item)
        {
            GameObject.Destroy(item.gameObject);
        }

        protected override void OnSpawned(TValue item)
        {
            item.gameObject.SetActive(true);
        }

        protected override void OnDespawned(TValue item)
        {
            item.gameObject.SetActive(false);

            if (item.transform.parent != _originalParent)
            {
                item.transform.SetParent(_originalParent, false);
            }
        }
    }

}