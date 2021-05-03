using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bottone_EsciDaArmadietto : MonoBehaviour
{
    public GameObject analogico;
    public GameObject bottone;
    public Transform player_posizione;
    private Transform ultima_posizione;
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
        this.ultima_posizione = GameObject.Find("Last_Player_Position").transform;
        this.player_posizione.position = this.ultima_posizione.position;
        analogico.SetActive(true);
        esci.gameObject.GetComponent<Image>().enabled = false;
        esci.gameObject.GetComponent<Button>().enabled = false;
    }
}
