using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Themplate.Runtime.Systems.Camera
{
    [RequireComponent(typeof(ControllerCameraShake))]
    public class CameraSystem : MonoBehaviour
    {
        #region References
        private Animator _cameraAnimator;
        private ControllerCameraShake _controllerCameraShake;
        public ControllerCameraShake ControllerCameraShake => _controllerCameraShake;
        #endregion


        private void Awake()
        {
            _controllerCameraShake = GetComponentInChildren<ControllerCameraShake>();
            _cameraAnimator = GetComponentInChildren<Animator>();
        }
        
        
        #region CHANGE_CAMERA_ACTIONS

        public void SetActiveCamera(string cameraParam)
        {
            _cameraAnimator.SetTrigger(cameraParam);
        }
        
        #endregion
    }
}

