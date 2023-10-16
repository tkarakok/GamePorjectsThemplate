using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Themplate.Runtime.Systems.GameState
{
    public class GameStateSystem : MonoBehaviour
    {
        [SerializeField] private GameState _gameState;


        public void ChangeGameState(GameState newGameState)
        {
            _gameState = newGameState;
        }
    }
}

