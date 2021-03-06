﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxAppoggio : MonoBehaviour
{
    public string Tag;
    public string nuovoTag;
    //private bool active;
    private int completo = 0;
    public bool indovinelloFinito = false;
    public GameObject libro2;
    public GameObject libro3;
    public Transform holder1;
    public Transform holder2;
    public Transform holder3;
    public Transform holder4;
    public Transform holder5;
    public Transform holder6;
    public GameObject bottone;
    int cont = 0;
    public GameObject enemy;
    public Transform spawn;

    private GameObject gestoreIndovinelli;
    public int numeroIndovinello;
    public FineGioco finegioco;

    private void Start()
    {
        gestoreIndovinelli = GameObject.Find("RiddlesControl");
        int count = Random.Range(1, 8);
        switch (count)
        {
            case 1:
                libro2.transform.position = holder2.position;
                libro3.transform.position = holder3.position;
                break;

            case 2:
                libro2.transform.position = holder3.position;
                libro3.transform.position = holder4.position;
                break;

            case 3:
                libro2.transform.position = holder2.position;
                libro3.transform.position = holder5.position;
                break;

            case 4:
                libro2.transform.position = holder1.position;
                libro3.transform.position = holder6.position;
                break;

            case 5:
                libro2.transform.position = holder3.position;
                libro3.transform.position = holder1.position;
                break;

            case 6:
                libro2.transform.position = holder4.position;
                libro3.transform.position = holder6.position;
                break;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (completo == 3)
        {
            if (cont == 0) {
                enemy.transform.position = spawn.transform.position;
                enemy.SetActive(true);
                indovinelloFinito = true;

                gestoreIndovinelli.GetComponent<Gestore_Indovinelli>().setIndovinelli(numeroIndovinello);
                finegioco.GetComponent<FineGioco>().FinisciGioco();

                Luci.luci = true;
                cont++;
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(Tag))
        {
            collision.gameObject.tag = nuovoTag;
            collision.gameObject.SetActive(false);
            if (collision.CompareTag(nuovoTag)) completo++;
        }
        if (collision.CompareTag("Player"))
        {
            bottone.SetActive(false);
            //this.active = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //this.active = false;
        }
    }

}
