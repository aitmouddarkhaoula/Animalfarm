using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {
    
    public float speed = 5f;


    public void Init() {
    }

    private void Update() {
        transform.Translate(Vector2.left * (speed * Time.deltaTime));
    }

    
}