using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Armadietto : MonoBehaviour
{
    private GameObject button_Nasconditi;

    // Start is called before the first frame update
    void Start()
    {
        this.button_Nasconditi = GameObject.Find("Bottone_Nasconditi");
    }

    // Update is called once per frame
    void Update()
    {
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            button_Nasconditi.gameObject.GetComponent<Image>().enabled = true;
            button_Nasconditi.gameObject.GetComponent<Button>().enabled = true;
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            button_Nasconditi.gameObject.GetComponent<Image>().enabled = false;
            button_Nasconditi.gameObject.GetComponent<Button>().enabled = false;

        }
    }
}
