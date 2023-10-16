using System.Collections;
using System.Collections.Generic;
using Themplate.Runtime.Systems.Singleton;
using UnityEngine;

namespace Themplate.Runtime.Core.Managers
{
    [DefaultExecutionOrder(100)]
    [RequireComponent(typeof(InputSystem))]
    public class ManagerInput : Singleton<ManagerInput>
    {
        #region REFERENCES
        public InputSystem InputSystem { get; private set; }
        // public ControllerUiJoystickCanvas ControllerUiJoystickCanvas { get; private set; }
        #endregion

        private void Awake()
        {
            //REFERENCES
            InputSystem = GetComponent<InputSystem>();
        }

        private void Start()
        {
            // //REFERENCES
            // ControllerUiJoystickCanvas = ManagerServiceLocator.Instance.ServiceLocatorSystem.GetService<ManagerUi>()
            //     .ControllerUiJoystickCanvas;
            //
            // if (InputSystem.InputType == InputType.Joystick)
            // {
            //     switch (InputSystem.JoystickType)
            //     {
            //         case JoystickType.Static:
            //             ControllerUiJoystickCanvas.SetActiveJoystick(JoystickType.Static);
            //                 
            //             break;
            //
            //         case JoystickType.Floating:
            //             ControllerUiJoystickCanvas.SetActiveJoystick(JoystickType.Floating);
            //                 
            //             break;
            //             
            //         case JoystickType.Dynamic:
            //             ControllerUiJoystickCanvas.SetActiveJoystick(JoystickType.Dynamic);
            //             break;
            //     }
            //     
            // }
       
        }
    }
}

