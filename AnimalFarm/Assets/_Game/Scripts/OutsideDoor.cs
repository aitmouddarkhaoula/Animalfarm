using UnityEngine;

public class OutsideDoor : MonoBehaviour {
    
    
    private void OnTriggerEnter2D(Collider2D col) {
        if (col.CompareTag("Player")) {
            GameStateManager.instance.SetGameState(GameStateManager.GameState.GameOver);
            print("GameLost");
        }
    }
    
}