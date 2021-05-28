using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quadro : MonoBehaviour
{
    public GameObject game;
    public Camera camera1;
    public bool playerInrange;
    // Start is called before the first frame update
    void Start()
    {
}

    // Update is called once per frame
    void FixedUpdate()
    {
       
        if(Input.GetKey(KeyCode.B) && playerInrange)
        {   
            game.SetActive(true);
            camera1.enabled = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInrange = true;
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInrange = false;
        }
    }
}
