using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSystem : MonoBehaviour {
    bool reachedHome;

    // Start is called before the first frame update
    void Start() {
        reachedHome = false;
    }

    // Update is called once per frame
    void Update() { }
    //void OnMouseDown()
    //{
    //    initialPostion = transform.position;

    //}
    private void OnMouseDrag() {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mousePosition.x, mousePosition.y, 0f);
    }

    private void OnMouseExit() {
        if (reachedHome) return;
        Vector3 pos = transform.position;
        if (pos.y > 2 ||pos.y < -2) {
            transform.position = new Vector3(pos.x, Random.Range(-1f,1f), 0f);
        }
        //else
        //{
        //    transform.position = pos;
        //}
    }

    // todo: Check this
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("Home")) {
            AnimalType animalSelected = GetComponentInParent<Animal>().selectedAnimal;
            AnimalType home = collision.GetComponent<AnimalHome>().selectedHome;
            if (animalSelected == home) {
                reachedHome = true;
                GetComponentInParent<Animal>().ReachedHome(collision.GetComponent<AnimalHome>().transform.position);
            }
            else {
                reachedHome = false;
                StartCoroutine(RedColor());
                //GetComponent<SpriteRenderer>().color = Color.red;
                GetComponentInParent<Animal>().WrongHome();
            }
        }
        //else
        //{
        //    GetComponent<SpriteRenderer>().color = Color.white;
        //}
    }

    IEnumerator RedColor() {
        GetComponent<SpriteRenderer>().color = Color.red;
        yield return new WaitForSeconds(1f);
        GetComponent<SpriteRenderer>().color = Color.white;
    }
}