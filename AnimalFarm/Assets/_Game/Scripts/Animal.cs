using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public enum AnimalType {
    Cow,
    Pig,
    Chicken
};

public class Animal : MonoBehaviour {
    public float speed = 5f;
    [SerializeField] float _duration = 2f;
    public AnimalType selectedAnimal = AnimalType.Cow;
    private Dropdown animalDropdown;


    private void Update() {
        transform.Translate(Vector2.left * (speed * Time.deltaTime));
    }

    public void ReachedHome(Vector3 housePos) {
        transform.DOMove(housePos, _duration);
        transform.DOScale(Vector3.zero, _duration);
    }

    public void WrongHome() {
        transform.DOShakePosition(1, 0.4f,10);
    }
}