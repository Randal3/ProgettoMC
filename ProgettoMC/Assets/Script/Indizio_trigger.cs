using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Indizio_trigger : MonoBehaviour
{
    public GameObject indizio;
    private GameObject button_Indizio;
    private GameObject button_Close;

    // Start is called before the first frame update
    void Start()
    {
        button_Close = GameObject.Find("Close");
        button_Indizio = GameObject.Find("Indizio");
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            button_Indizio.gameObject.GetComponent<Image>().enabled = true;
            button_Indizio.gameObject.GetComponent<Button>().enabled = true;
            indizio.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            button_Indizio.gameObject.GetComponent<Image>().enabled = false;
            button_Indizio.gameObject.GetComponent<Button>().enabled = false;
            indizio.gameObject.SetActive(false);
        }
    }
}
