using System;
using OknaaEXTENSIONS.CustomWrappers;
using UnityEngine;

public class SoundSystem : Singleton<SoundSystem> {
    private AudioSource audioSource;
    
    public AudioClip animalClickSound;

    private void Awake() {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayAnimalClickSound(AnimalType animalType) {
        audioSource.PlayOneShot(animalClickSound);
    
        
    }
}