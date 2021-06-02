using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MortePlayer : MonoBehaviour
{

    public Text tempo;

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }

    public void Setup(string minuti, string secondi)
    {
        gameObject.SetActive(true);
        tempo.text = minuti + ":" + secondi;
        Time.timeScale = 0;
    }
}