using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public AudioSource sound;
   
    public void Fade()
    {
        Debug.Log(sound.volume);
        StartCoroutine(FadeAudioSource.FadeOut(sound, 3f));
        Debug.Log("pippo");

    }
    public void Quit()
    {
        Application.Quit();
    }
}
