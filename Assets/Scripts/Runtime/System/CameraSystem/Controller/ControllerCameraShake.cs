using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

namespace Themplate.Runtime.Systems.Camera
{
    public class ControllerCameraShake : MonoBehaviour
    {
        private float _shakeTimer = 1;
        private float _shakeTimerTotal = 1;
        private float _startingIntensity = 1;
        
        public IEnumerator ShakeCamera(CinemachineVirtualCamera targetVirtualCamera, float intensity, float time)
        {
            CinemachineBasicMultiChannelPerlin cinemachineBasicMultiChannelPerlin =
                targetVirtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();

            cinemachineBasicMultiChannelPerlin.m_AmplitudeGain = intensity;

            _startingIntensity = intensity;
            _shakeTimerTotal = time;
            _shakeTimer = time;

            while (_shakeTimer > 0)
            {
                _shakeTimer -= Time.deltaTime;
                cinemachineBasicMultiChannelPerlin.m_AmplitudeGain = 
                    Mathf.Lerp(_startingIntensity, 0f, 1 - _shakeTimer / _shakeTimerTotal);

                yield return null;
            }
        }

    }
}


