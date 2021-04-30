using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Indizio_bottone : MonoBehaviour
{
    private GameObject indizi;
    private GameObject bottone_close;
    // Start is called before the first frame update
    void Start()
    {
        bottone_close = GameObject.Find("Close");
        indizi = GameObject.Find("Oggetti_Canvas");
    }
    // Update is called once per frame
    void Update()
    {
    }
    public void Guarda_Indizio()
    {
        Image[] ts = indizi.gameObject.GetComponentsInChildren<Image>();
        foreach (Image t in ts)
        {
            if (t != null && t.gameObject != null)
                t.gameObject.GetComponent<Image>().enabled = true;
        }
        bottone_close.gameObject.GetComponent<Image>().enabled = true;
        bottone_close.gameObject.GetComponent<Button>().enabled = true;
    }
}