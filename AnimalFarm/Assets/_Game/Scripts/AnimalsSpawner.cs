using System.Collections.Generic;
using OknaaEXTENSIONS;
using UnityEngine;
using Random = UnityEngine.Random;

public class AnimalsSpawner : MonoBehaviour {
    public List<Transform> spawnPoints = new List<Transform>();
    public List<Transform> animalPrefabs = new List<Transform>();

    public float spawnInterval = 5f;


    public void Init() {
        //GameStateSystem.OnGameStateChanged += OnGameStateChanged;
        InvokeRepeating(nameof(SpawnAnimals), 0f, spawnInterval);
    }

    private void SpawnAnimals() {
        var randomIndex = Random.Range(0, spawnPoints.Count);
        Instantiate(animalPrefabs.Random(), spawnPoints[randomIndex].position, Quaternion.identity);
    }
    public void Reset()
    {
        CancelInvoke();
        
    }
}