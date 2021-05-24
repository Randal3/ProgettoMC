using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FineGioco : MonoBehaviour
{

    public Text tempo;
    public void Setup(string time)
    {
        gameObject.SetActive(true);
        tempo.text = time.ToString();
    }

}
