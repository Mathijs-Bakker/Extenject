using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

namespace Zenject
{
    public class MonoPoolableMemoryPoolAsync<TValue>
        : MemoryPoolAsync<TValue>
        where TValue : Component, IPoolable
    {
        Transform _originalParent;

        [Inject]
        public MonoPoolableMemoryPoolAsync()
        {
        }

        protected override void OnCreated(TValue item)
        {
            item.gameObject.SetActive(false);
            _originalParent = item.transform.parent;
        }

        protected override void OnDestroyed(TValue item)
        {
            GameObject.Destroy(item.gameObject);
        }

        protected override void OnDespawned(TValue item)
        {
            item.OnDespawned();
            item.gameObject.SetActive(false);

            if (item.transform.parent != _originalParent)
            {
                item.transform.SetParent(_originalParent, false);
            }
        }

        protected override void Reinitialize( TValue item)
        {
            item.gameObject.SetActive(true);
            item.OnSpawned();
        }
    }
    public class MonoPoolableMemoryPoolAsync<TParam1, TValue>
        : MemoryPoolAsync<TParam1, TValue>
        where TValue : Component, IPoolable<TParam1>
    {
        Transform _originalParent;

        [Inject]
        public MonoPoolableMemoryPoolAsync()
        {
        }

        protected override void OnCreated(TValue item)
        {
            item.gameObject.SetActive(false);
            _originalParent = item.transform.parent;
        }

        protected override void OnDestroyed(TValue item)
        {
            GameObject.Destroy(item.gameObject);
        }

        protected override void OnDespawned(TValue item)
        {
            item.OnDespawned();
            item.gameObject.SetActive(false);

            if (item.transform.parent != _originalParent)
            {
                item.transform.SetParent(_originalParent, false);
            }
        }

        protected override void Reinitialize(TParam1 param1,  TValue item)
        {
            item.gameObject.SetActive(true);
            item.OnSpawned(param1);
        }
    }
    public class MonoPoolableMemoryPoolAsync<TParam1, TParam2, TValue>
        : MemoryPoolAsync<TParam1, TParam2, TValue>
        where TValue : Component, IPoolable<TParam1, TParam2>
    {
        Transform _originalParent;

        [Inject]
        public MonoPoolableMemoryPoolAsync()
        {
        }

        protected override void OnCreated(TValue item)
        {
            item.gameObject.SetActive(false);
            _originalParent = item.transform.parent;
        }

        protected override void OnDestroyed(TValue item)
        {
            GameObject.Destroy(item.gameObject);
        }

        protected override void OnDespawned(TValue item)
        {
            item.OnDespawned();
            item.gameObject.SetActive(false);

            if (item.transform.parent != _originalParent)
            {
                item.transform.SetParent(_originalParent, false);
            }
        }

        protected override void Reinitialize(TParam1 param1, TParam2 param2,  TValue item)
        {
            item.gameObject.SetActive(true);
            item.OnSpawned(param1, param2);
        }
    }
    public class MonoPoolableMemoryPoolAsync<TParam1, TParam2, TParam3, TValue>
        : MemoryPoolAsync<TParam1, TParam2, TParam3, TValue>
        where TValue : Component, IPoolable<TParam1, TParam2, TParam3>
    {
        Transform _originalParent;

        [Inject]
        public MonoPoolableMemoryPoolAsync()
        {
        }

        protected override void OnCreated(TValue item)
        {
            item.gameObject.SetActive(false);
            _originalParent = item.transform.parent;
        }

        protected override void OnDestroyed(TValue item)
        {
            GameObject.Destroy(item.gameObject);
        }

        protected override void OnDespawned(TValue item)
        {
            item.OnDespawned();
            item.gameObject.SetActive(false);

            if (item.transform.parent != _originalParent)
            {
                item.transform.SetParent(_originalParent, false);
            }
        }

        protected override void Reinitialize(TParam1 param1, TParam2 param2, TParam3 param3,  TValue item)
        {
            item.gameObject.SetActive(true);
            item.OnSpawned(param1, param2, param3);
        }
    }
    public class MonoPoolableMemoryPoolAsync<TParam1, TParam2, TParam3, TParam4, TValue>
        : MemoryPoolAsync<TParam1, TParam2, TParam3, TParam4, TValue>
        where TValue : Component, IPoolable<TParam1, TParam2, TParam3, TParam4>
    {
        Transform _originalParent;

        [Inject]
        public MonoPoolableMemoryPoolAsync()
        {
        }

        protected override void OnCreated(TValue item)
        {
            item.gameObject.SetActive(false);
            _originalParent = item.transform.parent;
        }

        protected override void OnDestroyed(TValue item)
        {
            GameObject.Destroy(item.gameObject);
        }

        protected override void OnDespawned(TValue item)
        {
            item.OnDespawned();
            item.gameObject.SetActive(false);

            if (item.transform.parent != _originalParent)
            {
                item.transform.SetParent(_originalParent, false);
            }
        }

        protected override void Reinitialize(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4,  TValue item)
        {
            item.gameObject.SetActive(true);
            item.OnSpawned(param1, param2, param3, param4);
        }
    }
    public class MonoPoolableMemoryPoolAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TValue>
        : MemoryPoolAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TValue>
        where TValue : Component, IPoolable<TParam1, TParam2, TParam3, TParam4, TParam5>
    {
        Transform _originalParent;

        [Inject]
        public MonoPoolableMemoryPoolAsync()
        {
        }

        protected override void OnCreated(TValue item)
        {
            item.gameObject.SetActive(false);
            _originalParent = item.transform.parent;
        }

        protected override void OnDestroyed(TValue item)
        {
            GameObject.Destroy(item.gameObject);
        }

        protected override void OnDespawned(TValue item)
        {
            item.OnDespawned();
            item.gameObject.SetActive(false);

            if (item.transform.parent != _originalParent)
            {
                item.transform.SetParent(_originalParent, false);
            }
        }

        protected override void Reinitialize(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5,  TValue item)
        {
            item.gameObject.SetActive(true);
            item.OnSpawned(param1, param2, param3, param4, param5);
        }
    }
    public class MonoPoolableMemoryPoolAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TValue>
        : MemoryPoolAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TValue>
        where TValue : Component, IPoolable<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6>
    {
        Transform _originalParent;

        [Inject]
        public MonoPoolableMemoryPoolAsync()
        {
        }

        protected override void OnCreated(TValue item)
        {
            item.gameObject.SetActive(false);
            _originalParent = item.transform.parent;
        }

        protected override void OnDestroyed(TValue item)
        {
            GameObject.Destroy(item.gameObject);
        }

        protected override void OnDespawned(TValue item)
        {
            item.OnDespawned();
            item.gameObject.SetActive(false);

            if (item.transform.parent != _originalParent)
            {
                item.transform.SetParent(_originalParent, false);
            }
        }

        protected override void Reinitialize(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6,  TValue item)
        {
            item.gameObject.SetActive(true);
            item.OnSpawned(param1, param2, param3, param4, param5, param6);
        }
    }
    public class MonoPoolableMemoryPoolAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TValue>
        : MemoryPoolAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TValue>
        where TValue : Component, IPoolable<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7>
    {
        Transform _originalParent;

        [Inject]
        public MonoPoolableMemoryPoolAsync()
        {
        }

        protected override void OnCreated(TValue item)
        {
            item.gameObject.SetActive(false);
            _originalParent = item.transform.parent;
        }

        protected override void OnDestroyed(TValue item)
        {
            GameObject.Destroy(item.gameObject);
        }

        protected override void OnDespawned(TValue item)
        {
            item.OnDespawned();
            item.gameObject.SetActive(false);

            if (item.transform.parent != _originalParent)
            {
                item.transform.SetParent(_originalParent, false);
            }
        }

        protected override void Reinitialize(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7,  TValue item)
        {
            item.gameObject.SetActive(true);
            item.OnSpawned(param1, param2, param3, param4, param5, param6, param7);
        }
    }
    public class MonoPoolableMemoryPoolAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TValue>
        : MemoryPoolAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TValue>
        where TValue : Component, IPoolable<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8>
    {
        Transform _originalParent;

        [Inject]
        public MonoPoolableMemoryPoolAsync()
        {
        }

        protected override void OnCreated(TValue item)
        {
            item.gameObject.SetActive(false);
            _originalParent = item.transform.parent;
        }

        protected override void OnDestroyed(TValue item)
        {
            GameObject.Destroy(item.gameObject);
        }

        protected override void OnDespawned(TValue item)
        {
            item.OnDespawned();
            item.gameObject.SetActive(false);

            if (item.transform.parent != _originalParent)
            {
                item.transform.SetParent(_originalParent, false);
            }
        }

        protected override void Reinitialize(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8,  TValue item)
        {
            item.gameObject.SetActive(true);
            item.OnSpawned(param1, param2, param3, param4, param5, param6, param7, param8);
        }
    }
    public class MonoPoolableMemoryPoolAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TValue>
        : MemoryPoolAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TValue>
        where TValue : Component, IPoolable<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9>
    {
        Transform _originalParent;

        [Inject]
        public MonoPoolableMemoryPoolAsync()
        {
        }

        protected override void OnCreated(TValue item)
        {
            item.gameObject.SetActive(false);
            _originalParent = item.transform.parent;
        }

        protected override void OnDestroyed(TValue item)
        {
            GameObject.Destroy(item.gameObject);
        }

        protected override void OnDespawned(TValue item)
        {
            item.OnDespawned();
            item.gameObject.SetActive(false);

            if (item.transform.parent != _originalParent)
            {
                item.transform.SetParent(_originalParent, false);
            }
        }

        protected override void Reinitialize(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9,  TValue item)
        {
            item.gameObject.SetActive(true);
            item.OnSpawned(param1, param2, param3, param4, param5, param6, param7, param8, param9);
        }
    }
    public class MonoPoolableMemoryPoolAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TValue>
        : MemoryPoolAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TValue>
        where TValue : Component, IPoolable<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10>
    {
        Transform _originalParent;

        [Inject]
        public MonoPoolableMemoryPoolAsync()
        {
        }

        protected override void OnCreated(TValue item)
        {
            item.gameObject.SetActive(false);
            _originalParent = item.transform.parent;
        }

        protected override void OnDestroyed(TValue item)
        {
            GameObject.Destroy(item.gameObject);
        }

        protected override void OnDespawned(TValue item)
        {
            item.OnDespawned();
            item.gameObject.SetActive(false);

            if (item.transform.parent != _originalParent)
            {
                item.transform.SetParent(_originalParent, false);
            }
        }

        protected override void Reinitialize(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9, TParam10 param10,  TValue item)
        {
            item.gameObject.SetActive(true);
            item.OnSpawned(param1, param2, param3, param4, param5, param6, param7, param8, param9, param10);
        }
    }
}