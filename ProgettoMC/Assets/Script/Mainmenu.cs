using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public AudioSource sound;
    private void Update()
    {
        Time.timeScale = 1;
    }
    public void Fade()
    {
        StartCoroutine(FadeAudioSource.FadeOut(sound, 3f));
   }
    public void Quit()
    {
        Application.Quit();
    }
}
