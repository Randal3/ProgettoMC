using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luci : MonoBehaviour
{
    public static bool luci=false;
    public GameObject corridoio;
    public GameObject player;
    public AudioSource alarm;
    public GameObject allarme;
    int cont = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (luci == true)
        {
            if(cont == 0)
            {
                spegniLuci();
            }
        }
        else
        {
            if (cont == 1)
            {
                corridoio.SetActive(true);
                GameObject.FindGameObjectWithTag("Luci").SetActive(true);
                player.SetActive(false);
                allarme.SetActive(false);
                
                cont = 0;
            }
        }
    }
            public void spegniLuci()
            {
                Debug.Log("Sono qui");
                for(int i = 0; i < 7; i++)
                {
                GameObject.FindGameObjectWithTag("Luci").SetActive(false);
                player.SetActive(true);
                allarme.SetActive(true);
                alarm.Play();
                cont = 1;
                }

            }

    }
