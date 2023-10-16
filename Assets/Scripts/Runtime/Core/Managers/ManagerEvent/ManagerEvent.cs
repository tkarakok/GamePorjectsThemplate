using System;
using System.Collections;
using System.Collections.Generic;
using Themplate.Runtime.Systems.Singleton;
using UnityEngine;

namespace Themplate.Runtime.Core.Managers
{
    [RequireComponent(typeof(EventSystem))]
    public class ManagerEvent : Singleton<ManagerEvent>
    {
        #region REF
        public EventSystem EventSystem { get; private set; }
        #endregion

        private void Awake()
        {
            EventSystem = GetComponent<EventSystem>();
        }

    }
}
    
