using System;
using System.Collections;
using System.Collections.Generic;
using Themplate.Runtime.Systems.Camera;
using Themplate.Runtime.Systems.Singleton;
using UnityEngine;

namespace Themplate.Runtime.Core.Managers
{
    public class ManagerCamera : Singleton<ManagerCamera>
    {
        public CameraSystem CameraSystem { get; private set; }

        private void Awake()
        {
            CameraSystem = FindObjectOfType<CameraSystem>();
        }
    }
}

