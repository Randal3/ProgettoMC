using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quadro : MonoBehaviour
{
   
    public GameObject player;
    public GameObject game;
    public Camera camera;
    public bool playerInrange;
    private GameObject button_Indizio;
    // Start is called before the first frame update
    void Start()
    {
        button_Indizio = GameObject.Find("Indizio");
}

    // Update is called once per frame
    void FixedUpdate()
    {
       
        if(Input.GetKey(KeyCode.B) && playerInrange)
        {   
            game.SetActive(true);
            button_Indizio.gameObject.GetComponent<Button>().enabled = true;
            camera.enabled = false;
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
