using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialog : MonoBehaviour
{

    public TextMeshProUGUI textDisplay;
    public GameObject BoxDialogo;
    public string sentences;
    public string sentencesBuio;
    private int index;
    private bool cont = false;
    private bool contBuio = false;
    public float wait;

    IEnumerator Type()
    {
        foreach(char letter in sentences.ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(0.05f);
        }
    }

    IEnumerator TypeBuio()
    {
        foreach (char letter in sentencesBuio.ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(0.05f);
        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(wait);
        textDisplay.text = "";
        BoxDialogo.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && cont == false && Luci.luci==false)
        {
            cont = true;
            BoxDialogo.SetActive(true);
            StartCoroutine(Type());
            StartCoroutine(Wait());
        }

        if (collision.CompareTag("Player") && contBuio == false && Luci.luci == true)
        {
            contBuio = true;
            BoxDialogo.SetActive(true);
            StartCoroutine(TypeBuio());
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
