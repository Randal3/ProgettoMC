using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip entraSound, esciSound, heavyBreathing,libreria;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        entraSound = Resources.Load<AudioClip>("entraSound");
        esciSound = Resources.Load<AudioClip>("esciSound");
        heavyBreathing = Resources.Load<AudioClip>("heavyBreathing");
        libreria = Resources.Load<AudioClip>("libreria");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    { 
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
        }
    }
}
