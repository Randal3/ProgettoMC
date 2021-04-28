using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quadro_trigger : MonoBehaviour
{
    public GameObject bottone;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            bottone.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            bottone.SetActive(false);
        }
    }
}
