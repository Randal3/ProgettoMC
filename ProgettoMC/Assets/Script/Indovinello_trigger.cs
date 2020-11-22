using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Indovinello_trigger : MonoBehaviour
{
    public int numeroIndovinello;
    public GameObject indovinello;

    private GameObject gestoreIndovinelli;
    private bool isCompletato;

    // Start is called before the first frame update
    void Start()
    {
        gestoreIndovinelli = GameObject.Find("RiddlesControl");
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isCompletato = (bool)gestoreIndovinelli.GetComponent<Gestore_Indovinelli>().getIndovinelli().GetValue(numeroIndovinello);
        if (collision.CompareTag("Player") && !isCompletato)
        {
            indovinello.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            indovinello.gameObject.SetActive(false);
        }
    }
}