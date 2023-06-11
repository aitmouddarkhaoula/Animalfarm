using System;
using OknaaEXTENSIONS.CustomWrappers;
using UnityEngine;

public enum GameState {
    Playing,
    Paused,
    GameWon,
    GameOver
}

public class GameStateSystem : Singleton<GameStateSystem> {
    public static Action<GameState> OnGameStateChanged;

    public GameState gameState;
    
    
    public void SetGameState(GameState state) {
        if (state == gameState) return;
        
        gameState = state;
        OnGameStateChanged?.Invoke(gameState);
    }
}