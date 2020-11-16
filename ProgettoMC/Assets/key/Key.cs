using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    private bool pickUpAllowed = false;

    // Use this for initialization
    private void Start()
    {
  
    }

    // Update is called once per frame
    private void Update()
    {
        if (pickUpAllowed && Input.GetKeyDown(KeyCode.E))
            PickUp();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            pickUpAllowed = true;
        }
    }
    private void PickUp()
    {
        Destroy(gameObject);
    }
}
