using System.Collections;
using System.Collections.Generic;
using Themplate.Runtime.Systems.Singleton;
using UnityEngine;


namespace Themplate.Runtime.Core.Managers
{
    [RequireComponent(typeof(SaveSystem))]
    public class ManagerSave : Singleton<ManagerSave>
    {
        public SaveSystem SaveSystem { get; private set; }

        private void Awake()
        {
            SaveSystem = GetComponent<SaveSystem>();
        }
    }
}

