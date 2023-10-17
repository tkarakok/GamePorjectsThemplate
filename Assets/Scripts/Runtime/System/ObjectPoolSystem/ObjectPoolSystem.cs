using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Themplate.Runtime.Systems.ObjectPool
{
    [System.Serializable]
    public class ObjectPoolSystem
    {
        public PoolType PoolType;
        public GameObject PoolObjectPrefab;
        public Transform PoolParent;
        public int PoolSize;
        public Queue<GameObject> PoolQueue;

        public void Initialize()
        {
            PoolQueue = new Queue<GameObject>();
            for (int i = 0; i < PoolSize; i++)
            {
                GameObject newPoolObject = GameObject.Instantiate(PoolObjectPrefab, PoolParent);
                newPoolObject.SetActive(false);
                PoolQueue.Enqueue(newPoolObject);
            }
        }
        
        public GameObject GetPoolObject()
        {
            GameObject poolObject = PoolQueue.Dequeue();
            poolObject.SetActive(true);
            PoolQueue.Enqueue(poolObject);
            return poolObject;
        }
    }
}


