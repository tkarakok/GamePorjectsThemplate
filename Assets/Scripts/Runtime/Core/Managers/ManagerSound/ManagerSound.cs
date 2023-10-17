using System.Collections;
using System.Collections.Generic;
using Themplate.Runtime.Core.Managers;
using Themplate.Runtime.Systems.Singleton;
using Themplate.Runtime.Systems.Sound;
using UnityEngine;

namespace Themplate.Runtime.Core.Managers
{
    [RequireComponent(typeof(SoundSystem))]
    public class ManagerSound : Singleton<ManagerSound>
    {
        private SaveSystem _saveSystem;
        private SoundSystem _soundSystem;
    
        public SoundSystem SoundSystem
        {
            get
            {
                if (_saveSystem != null && _saveSystem.SaveState != null)
                {
                    bool isSoundOn = _saveSystem.SaveState.IsVibrationOn;
           
                    _soundSystem.SetPreventSound(!isSoundOn);
                }
     
                return _soundSystem;
            }
            private set { }
        }

        private void Awake()
        {
            _soundSystem = GetComponent<SoundSystem>();
        }

        private void Start()
        {
            _saveSystem = ManagerSave.Instance.SaveSystem;
        }

    }
}

