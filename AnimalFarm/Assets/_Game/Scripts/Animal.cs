
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public enum AnimalType {
    Cow, 
    Sheap, 
    Chicken 
};
public class Animal : MonoBehaviour { 

    public float speed = 5f;
    [SerializeField] float _duration=2f;
    public AnimalType selectedAnimal;
    private Dropdown animalDropdown;

    private void Start()
    {
        Init();
    }
    public void Init()
    {
        // Hook up the dropdown's value change event to a method
        animalDropdown.onValueChanged.AddListener(OnAnimalDropdownValueChanged);

        // Set the default selected animal
        selectedAnimal = AnimalType.Cow;
    }

    private void OnAnimalDropdownValueChanged(int index)
    {
        // Update the selected animal based on the dropdown value
        selectedAnimal = (AnimalType)index;
    }

    private void Update()
    {
        transform.Translate(Vector2.left * (speed * Time.deltaTime));
    }
    public void ReachedHome(Vector3 housePos)
    {
        //transform.position = housePos;
        transform.DOMove(housePos, _duration);
        transform.DOScale(Vector3.zero, _duration);
        //Destroy(gameObject);
        
    }
    public void WrongHome()
    {
        transform.DOShakePosition(1, 0.4f,10);
    }
  




}