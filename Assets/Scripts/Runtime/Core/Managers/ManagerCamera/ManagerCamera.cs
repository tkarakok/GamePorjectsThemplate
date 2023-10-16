using System;
using System.Collections;
using System.Collections.Generic;
using Themplate.Runtime.Systems.Camera;
using UnityEngine;

namespace Themplate.Runtime.Core.Managers
{
    public class ManagerCamera : MonoBehaviour
    {
        public CameraSystem CameraSystem { get; private set; }

        private void Awake()
        {
            CameraSystem = FindObjectOfType<CameraSystem>();
        }
    }
}

