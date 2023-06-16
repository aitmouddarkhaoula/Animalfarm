using _Game.Scripts;
using UnityEngine;

public class GameStateManager : MonoBehaviour {
    public static GameStateManager instance;

    // Define different game states
    public enum GameState {
        MainMenu,
        Gameplay,
        PauseMenu,
        GameOver
    }

    [SerializeField] public UISystem UIManager;
    [SerializeField] public ScoreSystem score;
    [SerializeField] public AnimalsSpawner animal;

    // Current game state
    private GameState currentState;

    private void Awake() {
        // Ensure only one instance exists
        if (instance != null && instance != this) {
            Destroy(this.gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    private void Start() {
        // Set initial game state
        SetGameState(GameState.MainMenu);
    }

    private void Update() {
        //// Check for input or conditions to change game state

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    if (currentState == GameState.MainMenu)
        //    {
        //        // Transition from main menu to gameplay
        //        SetGameState(GameState.Gameplay);
        //    }
        //    else if (currentState == GameState.Gameplay)
        //    {
        //        // Transition from gameplay to pause menu
        //        SetGameState(GameState.PauseMenu);
        //    }
        //    else if (currentState == GameState.PauseMenu)
        //    {
        //        // Transition from pause menu to gameplay
        //        SetGameState(GameState.Gameplay);
        //    }
        //    else if (currentState == GameState.GameOver)
        //    {
        //        // Transition from game over to main menu
        //        SetGameState(GameState.MainMenu);
        //    }
        //}
    }

    public void SetGameState(GameState newState) {
        // Exit the current state
        ExitState(currentState);

        // Set the new state
        currentState = newState;

        // Enter the new state
        EnterState(currentState);
    }

    private void EnterState(GameState state) {
        // Perform actions when entering a state

        switch (state) {
            case GameState.MainMenu:

                Debug.Log("Entered Main Menu state");
                UIManager.ShowMainMenuWindow();
                break;
            case GameState.Gameplay:
                Debug.Log("Entered Gameplay state");
                // Start gameplay, enable player controls, etc.
                UIManager.ShowGamePlayingWindow();
                animal.Init();
                break;
            case GameState.PauseMenu:
                Debug.Log("Entered Pause Menu state");

                // Pause gameplay, show pause menu UI, etc.
                break;
            case GameState.GameOver:
                Debug.Log("Entered Game Over state");
                UIManager.ShowGameOverWindow();
                animal.Reset();
                // Stop gameplay, show game over UI, etc.
                break;
        }
    }

    public void ExitState(GameState state) {
        // Perform actions when exiting a state

        switch (state) {
            case GameState.MainMenu:
                // Hide main menu UI, clean up game settings, etc.
                break;
            case GameState.Gameplay:
                // Stop gameplay, disable player controls, etc.
                break;
            case GameState.PauseMenu:
                // Resume gameplay, hide pause menu UI, etc.
                break;
            case GameState.GameOver:
                // Hide game over UI, reset game state, etc.
                break;
        }
    }
}