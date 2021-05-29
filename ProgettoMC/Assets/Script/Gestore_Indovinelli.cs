using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gestore_Indovinelli : MonoBehaviour
{

    private bool[] indovinelli;
    // Start is called before the first frame update
    void Start()
    {
        indovinelli = new bool[4];
        for (int i = 0; i <= 3; i++)
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
         indovinelli[numeroIndovinello] = true;
    }

    public bool isFinito()
    {
        /*
        bool finito = true;
        for (int i = 0; i < 4 && finito; i++)
            if (this.indovinelli[i] != true)
                 finito = false;
        return finito;
        */
        return true;
    }
}
