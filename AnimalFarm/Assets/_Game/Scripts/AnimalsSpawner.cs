using System.Collections.Generic;
using OknaaEXTENSIONS;
using UnityEngine;
using Random = UnityEngine.Random;

public class AnimalsSpawner : MonoBehaviour {
    public List<Transform> spawnPoints = new List<Transform>();
    public List<Transform> animalPrefabs = new List<Transform>();

    public float spawnInterval = 5f;


    private void Start() {
        GameStateSystem.OnGameStateChanged += OnGameStateChanged;
        InvokeRepeating(nameof(SpawnAnimals), 0f, spawnInterval);
    }

    private void OnGameStateChanged(GameState obj) {
        switch (obj) {
            case GameState.GameOver or GameState.GameWon:
            case GameState.Paused:
                CancelInvoke(nameof(SpawnAnimals));
                break;
            case GameState.Playing:
                InvokeRepeating(nameof(SpawnAnimals), 0f, spawnInterval);
                break;
        }
    }

    private void SpawnAnimals() {
        var randomIndex = Random.Range(0, spawnPoints.Count);
        Instantiate(animalPrefabs.Random(), spawnPoints[randomIndex].position, Quaternion.identity);
    }
}