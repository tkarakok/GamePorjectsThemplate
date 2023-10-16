using System;
using System.Collections;
using System.Collections.Generic;
using Themplate.Runtime.Systems.GameState;
using UnityEngine;

namespace Themplate.Runtime.Core.Managers
{
    [RequireComponent(typeof(GameStateSystem))]
    public class ManagerGame : MonoBehaviour
    {
        #region REF
        public GameStateSystem GameStateSystem { get; private set; }

        #endregion

        private void Awake()
        {
            GameStateSystem = GetComponent<GameStateSystem>();
        }
    }
}

