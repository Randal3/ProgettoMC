﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Indizio_trigger : MonoBehaviour
{
    public GameObject indizio;
    private GameObject button_Indizio;

    // Start is called before the first frame update
    void Start()
    {
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
            Debug.Log("ciao");
            button_Indizio.gameObject.GetComponent<Image>().enabled = true;
            button_Indizio.gameObject.GetComponent<Button>().enabled = true;
            indizio.SetActive(true);
            Debug.Log("ssciao");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            button_Indizio.gameObject.GetComponent<Image>().enabled = false;
            button_Indizio.gameObject.GetComponent<Button>().enabled = false;
            indizio.SetActive(false);
        }
    }
}
