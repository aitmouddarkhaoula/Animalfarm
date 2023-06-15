using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GameStateManager;

public class UISystem : MonoBehaviour
{
    [SerializeField] GameObject MainMenuWindow;
    [SerializeField] GameObject GamePlayWindow;
    [SerializeField] GameObject GameOverWindow;

    public static UISystem UIManager;
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenuWindow();
       
            
    }
    public void ShowMainMenuWindow()
    {
        MainMenuWindow.gameObject.SetActive(true);
        GamePlayWindow.gameObject.SetActive(false);
        GameOverWindow.gameObject.SetActive(false);
    }
    public void ShowGamePlayingWindow()
    {
        MainMenuWindow.gameObject.SetActive(false);
        GamePlayWindow.gameObject.SetActive(true);
        GameOverWindow.gameObject.SetActive(false);
    }
    public void ShowGameOverWindow()
    {
        MainMenuWindow.gameObject.SetActive(false);
        GamePlayWindow.gameObject.SetActive(false);
        GameOverWindow.gameObject.SetActive(true);
    }
    public void PlayGame()
    {
        GameStateManager.instance.SetGameState(GameState.Gameplay);
    }
    public void RestartGame()
    {
        GameStateManager.instance.SetGameState(GameState.MainMenu);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
