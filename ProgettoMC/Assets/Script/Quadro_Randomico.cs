﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quadro_Randomico : MonoBehaviour
{
    public GameObject indizio_quadro;
    private string soluzione;
    // Start is called before the first frame update
    void Start()
    {
        Sprite[] quadri = Resources.LoadAll<Sprite>("Quadri");
        Sprite quadro = quadri[Random.Range(0, quadri.Length)];
        indizio_quadro.GetComponent<Image>().sprite = quadro;
        soluzione = indizio_quadro.GetComponent<Image>().sprite.name;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public string getSoluzione()
    {
        return this.soluzione;
    }
}
