using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayIndo : MonoBehaviour
{
    public bool playerInrange;
    public GameObject game;
    // Start is called before the first frame update
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

    // Update is called once per frame
    void Update()
    {
        if (playerInrange)
        {
            game.SetActive(true);
        }
    }
}
