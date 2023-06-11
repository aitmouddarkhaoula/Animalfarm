using UnityEngine;
using UnityEngine.UI;

public class AnimalHome : MonoBehaviour {
    public AnimalType selectedHome;
    private Dropdown homeDropdown;

    private void Start() {
        Init();
    }

    private void Init() {
        // Hook up the dropdown's value change event to a method
        homeDropdown.onValueChanged.AddListener(OnAnimalDropdownValueChanged);

        // Set the default selected animal
        selectedHome = AnimalType.Cow;
    }

    private void OnAnimalDropdownValueChanged(int index) {
        // Update the selected animal based on the dropdown value
        selectedHome = (AnimalType)index;
    }
}