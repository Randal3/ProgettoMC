using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioClip[] pippo;
    static AudioClip entra,esci,libreria,cuore,cancello;
    static AudioSource music;
    // Start is called before the first frame update
    void Start()
    {
        music = GetComponent<AudioSource>();
        entra = pippo[0];
        esci = pippo[1];
        cancello = pippo[2];
        libreria = pippo[3];
        cuore = pippo[4];
    }

    // Update is called once per frame
    public static void Mauro(string clip)
    {
        switch (clip)
        {
            case "entra":
                music.PlayOneShot(entra);
                music.PlayOneShot(cuore);
                break;
            case "esci":
                music.Stop();
                music.PlayOneShot(esci);
                break;
            case "libreria":
                music.PlayOneShot(libreria);
                break;
            case "cancello":
                Debug.Log("pippo");
                music.PlayOneShot(cancello);
                break;
        }

    }
    }
}
