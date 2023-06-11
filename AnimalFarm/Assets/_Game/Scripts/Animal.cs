using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System.Collections;

public enum AnimalType {
    Cow,
    Pig,
    Chicken
};

public class Animal : MonoBehaviour {
    public float speed = 5f;
    [SerializeField] float _duration = 2f;
    public AnimalType selectedAnimal;
    private Dropdown animalDropdown;

    private void Start() => Init();

    public void Init() {
        // Hook up the dropdown's value change event to a method
        animalDropdown.onValueChanged.AddListener(OnAnimalDropdownValueChanged);

        // Set the default selected animal
        selectedAnimal = AnimalType.Cow;
    }

    private void OnAnimalDropdownValueChanged(int index) {
        // Update the selected animal based on the dropdown value
        selectedAnimal = (AnimalType)index;
    }

    private void Update() {
        transform.Translate(Vector2.left * (speed * Time.deltaTime));
    }

    public void ReachedHome(Vector3 housePos) {
        //transform.position = housePos;
        GameStateManager.instance.score.AddScore(2);
        transform.DOMove(housePos, _duration);
        transform.DOScale(Vector3.zero, _duration);
        StartCoroutine(Destroy());
        IEnumerator Destroy()
        {
            yield return new WaitForSeconds(2f);
            OnDestroy();
        }
        //Destroy(gameObject);
    }
    public void WrongHome()
    {
        GameStateManager.instance.score.RemoveScore(-2);
        transform.DOShakePosition(1, 0.4f,10);
    }
    public void Reset()
    {
        Vector3 pos = transform.position;
        transform.position = pos;
    }
    public void OnDestroy()
    {
        Destroy(gameObject);
    }





}