using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gestore_Indovinelli : MonoBehaviour
{

    private bool[] indovinelli;
    // Start is called before the first frame update
    void Start()
    {
        indovinelli = new bool[8];
        for (int i = 0; i <= 7; i++)
            indovinelli[i] = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public bool[] getIndovinelli()
    {
        return this.indovinelli;
    }

    public void setIndovinelli(int numeroIndovinello)
    {
         this.indovinelli[numeroIndovinello] = true;
    }
}
