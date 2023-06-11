using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class AnimalsSpawner : MonoBehaviour {
    public List<Transform> spawnPoints = new List<Transform>();

    public Animal animalPrefab;
    public float spawnInterval = 5f;


    private void Start() {
        InvokeRepeating(nameof(SpawnAnimals), 0f, spawnInterval);
    }

    private void SpawnAnimals() {
        var randomIndex = Random.Range(0, spawnPoints.Count);
        Instantiate(animalPrefab, spawnPoints[randomIndex].position, Quaternion.identity);
    }
}