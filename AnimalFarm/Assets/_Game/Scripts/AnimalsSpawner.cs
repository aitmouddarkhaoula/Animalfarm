using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalsSpawner : MonoBehaviour {
    
    public List<Transform> spawnPoints = new List<Transform>();
    
    public Animal animalPrefab;
    public float spawnInterval = 5f;


    private void Start() {
        StartCoroutine(SpawnAnimals());
    }
    
    private IEnumerator SpawnAnimals() {
        while (true) {
            yield return new WaitForSeconds(spawnInterval);
            int randomIndex = UnityEngine.Random.Range(0, spawnPoints.Count);
            Transform spawnPoint = spawnPoints[randomIndex];
            Instantiate(animalPrefab, spawnPoint.position, Quaternion.identity);
        }
    }
    
    private void OnTriggerEnter2D(Collider2D col) {
        if (col.CompareTag("Player")) {
            print("GameLost");
            
        }
    }
}