using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quadro : MonoBehaviour
{
   
    public GameObject player;
    public GameObject game;
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
            Debug.Log("2");
            player.SetActive(false);
            game.SetActive(true);
           



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
