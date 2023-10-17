using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Themplate.Runtime.Systems.ObjectPool;
using Themplate.Runtime.Systems.Singleton;
using UnityEngine;

namespace Themplate.Runtime.Core.Managers
{
    public class ManagerObjectPool : Singleton<ManagerObjectPool>
    {
        public ObjectPoolSystem[] ObjectPoolSystems;

        private void Start()
        {
            foreach (var pool in ObjectPoolSystems)
            {
                pool.Initialize();
            }
        }

        public ObjectPoolSystem GetObjectPoolSystem(PoolType poolType)
        {
            return ObjectPoolSystems.FirstOrDefault(x => x.PoolType == poolType);
        }
    }
}
