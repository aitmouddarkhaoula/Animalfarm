using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSystem : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

    }
    //void OnMouseDown()
    //{
    //    initialPostion = transform.position;

    //}
    private void OnMouseDrag()
    {
        
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mousePosition.x, mousePosition.y, 0f);
    }
    //private void OnMouseExit()
    //{
    //    transform.position = initialPostion;
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.gameObject.CompareTag("Home"))
        //{
        //    AnimalHome home = collision.GetComponent<AnimalHome>();
        //}

    }
}
