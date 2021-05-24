using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FineGioco : MonoBehaviour
{

    public Text tempo;

    public void menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Setup(string minuti,string secondi)
    {
        gameObject.SetActive(true);
        tempo.text = minuti + ":" + secondi;
        Time.timeScale = 0;
    }



}
