using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bottone_EsciDaArmadietto : MonoBehaviour
{
    public GameObject analogico;
    public GameObject bottone;
    public GameObject player;
    private Transform ultima_posizione;
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
        this.ultima_posizione = GameObject.Find("Last_Player_Position").transform;
        this.player.transform.position = this.ultima_posizione.position;
        this.player.GetComponent<SpriteRenderer>().enabled = true;
        mostro.spatialBlend = 1;
        analogico.SetActive(true);
        esci.gameObject.GetComponent<Image>().enabled = false;
        esci.gameObject.GetComponent<Button>().enabled = false;
        SoundManager.PlaySound("esci");
    }
}
