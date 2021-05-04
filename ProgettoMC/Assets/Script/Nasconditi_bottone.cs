using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Nasconditi_bottone : MonoBehaviour
{
    public GameObject analogico;
    public Transform nascondiglio;
    public Transform player_posizione;
    public GameObject bottone;
    public Transform posizioneDaRicordare;
    private GameObject esci;

    // Start is called before the first frame update
    void Start()
    {
        esci = GameObject.Find("Bottone_EsciDaArmadietto");
        gameObject.GetComponent<Button>().onClick.AddListener(ButtonClicked);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ButtonClicked()
    {
        this.posizioneDaRicordare.position = this.player_posizione.position;
        analogico.SetActive(false);
        this.player_posizione.position = this.nascondiglio.position;
        esci.gameObject.GetComponent<Image>().enabled = true;
        esci.gameObject.GetComponent<Button>().enabled = true;
        soundManager.PlaySound("entra");
    }
}
