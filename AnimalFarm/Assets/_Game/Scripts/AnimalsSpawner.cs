using System.Collections.Generic;
using OknaaEXTENSIONS;
using UnityEngine;
using Random = UnityEngine.Random;

public class AnimalsSpawner : MonoBehaviour {
    public List<GameObject> spawnedAnimals;
    public List<Transform> spawnPoints = new List<Transform>();
    public List<Transform> animalPrefabs = new List<Transform>();

    public float spawnInterval = 5f;


    public void Init() {
        //GameStateSystem.OnGameStateChanged += OnGameStateChanged;
        InvokeRepeating(nameof(SpawnAnimals), 0f, spawnInterval);
    }

    private void SpawnAnimals() {
        var randomIndex = Random.Range(0, spawnPoints.Count);
        Transform animal = Instantiate(animalPrefabs.Random(), spawnPoints[randomIndex].position, Quaternion.identity);
        spawnedAnimals.Add(animal.gameObject);
    }
    public void Reset()
    {
        CancelInvoke();
        DestroyAllAnimals();
    }
    public void DestroyAllAnimals() {
        foreach (var animal in spawnedAnimals) {
            Destroy(animal);
        }
    }
}