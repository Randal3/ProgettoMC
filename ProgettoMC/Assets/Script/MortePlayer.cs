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

    public void Setup(string v)
    {
        Luci.luci = false;
        morto.SetActive(true);
        tempo.text = v;
        Invoke("FineGioco", 4);
        }
    void FineGioco()
    {
        morto.SetActive(false);
        gameObject.SetActive(true);
    }
}