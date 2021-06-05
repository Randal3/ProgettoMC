using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialog : MonoBehaviour
{

    public TextMeshProUGUI textDisplay;
    public GameObject BoxDialogo;
    public string sentences;
    private int index;
    private bool cont = false;
    IEnumerator Type()
    {
        foreach(char letter in sentences.ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(0.1f);
        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(5.0f);
        textDisplay.text = "";
        BoxDialogo.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && cont == false)
        {
            cont = true;
            BoxDialogo.SetActive(true);
            StartCoroutine(Type());
            StartCoroutine(Wait());
        }
    }

    /*private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            attesa();
        }
    }*/
}
