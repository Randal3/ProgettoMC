using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public static int n = 0;
    public GameObject button;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        n = 0;
        if (collision.gameObject.name=="quadro")
        {
            button.SetActive(true);
            n = 1;
        }
        else if(collision.gameObject.name == "Object1")
        {
            button.SetActive(true);
            n = 2;
        }
        else if (collision.gameObject.name == "object")
        {
            button.SetActive(true);
            n = 3;
        }
        else if (collision.gameObject.name == "warning")
        {
            button.SetActive(true);
            n = 4;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "quadro")
        {
            button.SetActive(false);
        }
        else if (collision.gameObject.name == "Object1")
        {
            button.SetActive(false);
        }
        else if (collision.gameObject.name == "object")
        {
            button.SetActive(false);
        }
        else if (collision.gameObject.name == "warning")
        {
            button.SetActive(false);
        }
    }

}
