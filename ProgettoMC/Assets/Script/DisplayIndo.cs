using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayIndo : MonoBehaviour
{
    public bool playerInrange;
    public GameObject butt;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInrange = true;
            butt.SetActive(true);
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInrange = false;
            butt.SetActive(false);
        }
    }
}
