using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alarm_script : MonoBehaviour
{
    public AudioSource audio;
    // Start is called before the first frame update
    void Update()
    {
        if (Engine.wire && Soluzione.youWin)
        {
            print("22");
            audio.Play();
        }
    }

   
}
