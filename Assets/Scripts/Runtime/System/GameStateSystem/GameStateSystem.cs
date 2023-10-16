using System.Collections;
using System.Collections.Generic;
using Themplate.Runtime.Core.Managers;
using UnityEngine;

namespace Themplate.Runtime.Systems.GameState
{
    public class GameStateSystem : MonoBehaviour
    {
        [SerializeField] private GameState _gameState;


        public void ChangeGameState(GameState newGameState)
        {
            _gameState = newGameState;
            ManagerEvent.Instance.EventSystem.GetEvent<EventSystem.OnGameStateChange>().Execute(newGameState);
        }
    }
}

