using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip entraSound, esciSound, heavyBreathing,libreria,cancello;
    static AudioSource audioSrc;


    void Start()
    {
        entraSound = Resources.Load<AudioClip>("entraSound");
        esciSound = Resources.Load<AudioClip>("esciSound");
        heavyBreathing = Resources.Load<AudioClip>("heavyBreathing");
        libreria = Resources.Load<AudioClip>("libreria");
        cancello = Resources.Load<AudioClip>("cancello");
        audioSrc = GetComponent<AudioSource>();
    }


    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "entra":
                audioSrc.PlayOneShot(entraSound);
                audioSrc.PlayOneShot(heavyBreathing);
                break;
            case "esci":
                audioSrc.Stop();
                audioSrc.PlayOneShot(esciSound);
                break;
            case "libreria":
                audioSrc.PlayOneShot(libreria);
                break;
            case "cancello":
                Debug.Log("pippo");
                audioSrc.PlayOneShot(cancello);
                break;
        }
    }
}
