using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//public enum HomeType
//{
//    Cow,
//    Sheap,
//    Chicken
//};
public class AnimalHome : MonoBehaviour
{
    public AnimalType selectedHome;
    private Dropdown homeDropdown;
    // Start is called before the first frame update
    private void Start()
    {
        Init();
    }
    public void Init()
    {
        // Hook up the dropdown's value change event to a method
        homeDropdown.onValueChanged.AddListener(OnAnimalDropdownValueChanged);

        // Set the default selected animal
        selectedHome = AnimalType.Cow;
    }

    private void OnAnimalDropdownValueChanged(int index)
    {
        // Update the selected animal based on the dropdown value
        selectedHome = (AnimalType)index;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
