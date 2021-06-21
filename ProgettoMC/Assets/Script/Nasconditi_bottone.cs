using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Nasconditi_bottone : MonoBehaviour
{
    public GameObject analogico;
    public Transform nascondiglio;
    public GameObject player;
    public GameObject bottone;
    public Transform posizioneDaRicordare;
    private GameObject esci;
    public AudioSource mostro;


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
        this.posizioneDaRicordare.position = this.player.transform.position;
        analogico.SetActive(false);
        mostro.spatialBlend = 0;
        this.player.transform.position = this.nascondiglio.position;
        this.player.GetComponent<SpriteRenderer>().enabled = false;
        esci.gameObject.GetComponent<Image>().enabled = true;
        esci.gameObject.GetComponent<Button>().enabled = true;
        SoundManager.PlaySound("entra");
    }
}
