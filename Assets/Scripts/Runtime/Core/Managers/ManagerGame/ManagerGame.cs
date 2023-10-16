using System;
using System.Collections;
using System.Collections.Generic;
using Themplate.Runtime.Systems.GameState;
using Themplate.Runtime.Systems.Singleton;
using UnityEngine;

namespace Themplate.Runtime.Core.Managers
{
    [RequireComponent(typeof(GameStateSystem))]
    public class ManagerGame : Singleton<ManagerGame>
    {
        #region REF
        public GameStateSystem GameStateSystem { get; private set; }

        #endregion

        private void Awake()
        {
            GameStateSystem = GetComponent<GameStateSystem>();
        }

        private void OnEnable()
        {
            ManagerEvent.Instance.EventSystem.GetEvent<EventSystem.OnGameStateChange>().AddListener(GameStateSystem.ChangeGameState);
        }

        private void OnDisable()
        {
            ManagerEvent.Instance.EventSystem.GetEvent<EventSystem.OnGameStateChange>().RemoveListener(GameStateSystem.ChangeGameState);
            
        }
        
    }
}

