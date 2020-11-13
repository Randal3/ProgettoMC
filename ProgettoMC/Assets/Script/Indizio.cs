using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Indizio : MonoBehaviour
{
    public GameObject indizio;
    public GameObject button_Indizio;
    public GameObject button_Close;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            button_Indizio.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            button_Indizio.gameObject.SetActive(false);
        }
    }

    public void ShowIndizio()
    {
        indizio.gameObject.GetComponent<Image>().enabled = true;
        button_Close.gameObject.SetActive(true);

    }
}
