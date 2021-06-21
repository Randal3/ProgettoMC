using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public GameObject Main;
    public GameObject Background;
    // Update is called once per frame
    void Awake()
    {
        Invoke("off", 17f);       
    }
    public void off()
    {
        Main.SetActive(true);
        Background.SetActive(true);
        gameObject.SetActive(false);
    }
}
