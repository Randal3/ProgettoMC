using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luci : MonoBehaviour
{
    public static bool luci=false;
    public GameObject corridoio;
    public GameObject player;
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
            //GameObject.FindGameObjectWithTag("Luci").SetActive(false);
            player.SetActive(true);
            allarme.SetActive(true);
            cont = 1;
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

        /*
            public static void spegniLuci()
            {
                Debug.Log("Sono qui");
                while(cont < 20) {
                    GameObject.FindGameObjectWithTag("Luci").SetActive(false); 
                    cont++;
                }
            }

            public static void accendiLuci()
            {
                cont = 0;
                Debug.Log("Sono Accese");
                while (cont < 20)
                {
                    Debug.Log("S121423124");
                    GameObject.FindGameObjectWithTag("Luci").SetActive(true);
                    cont++;
                }
            }*/
    }
