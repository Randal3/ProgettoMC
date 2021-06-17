using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MortePlayer : MonoBehaviour
{
    public GameObject morto;
    public Text tempo;

    public void Menu()
    {
        SceneManager.LoadScene("Menu");   
    }

    public void Setup(string minuti, string secondi)
    {
        Luci.luci = false;
        morto.SetActive(true);
        tempo.text = minuti + ":" + secondi;
        Invoke("FineGioco", 4);
        }
    void FineGioco()
    {
        morto.SetActive(false);
        gameObject.SetActive(true);
    }
}