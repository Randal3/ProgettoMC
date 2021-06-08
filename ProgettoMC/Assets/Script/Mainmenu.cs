using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public Animator sound;
   public void OffAnimator()
    {
        sound.enabled = false;
    }

    public void OnAnimazione()
    {
        sound.enabled = true;
    }
    public void Quit()
    {
        Application.Quit();
    }
}
