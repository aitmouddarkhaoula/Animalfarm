using System.Collections;
using System.Collections.Generic;
using OknaaEXTENSIONS.CustomWrappers;
using UnityEngine;
using static GameStateManager;

public class UISystem : Singleton<UISystem> {
    [SerializeField] private GameObject MainMenuWindow;
    [SerializeField] private GameObject GamePlayWindow;
    [SerializeField] private GameObject GameOverWindow;

    private void Start() {
        ShowMainMenuWindow();
    }

    public void ShowMainMenuWindow() {
        MainMenuWindow.gameObject.SetActive(true);
        GamePlayWindow.gameObject.SetActive(false);
        GameOverWindow.gameObject.SetActive(false);
    }

    public void ShowGamePlayingWindow() {
        MainMenuWindow.gameObject.SetActive(false);
        GamePlayWindow.gameObject.SetActive(true);
        GameOverWindow.gameObject.SetActive(false);
    }

    public void ShowGameOverWindow() {
        MainMenuWindow.gameObject.SetActive(false);
        GamePlayWindow.gameObject.SetActive(false);
        GameOverWindow.gameObject.SetActive(true);
    }

    public void PlayGame() {
        GameStateManager.instance.SetGameState(GameState.Gameplay);
    }

    public void RestartGame() {
        GameStateManager.instance.SetGameState(GameState.MainMenu);
    }
}