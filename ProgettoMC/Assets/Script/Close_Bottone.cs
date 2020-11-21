using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Close_Bottone : MonoBehaviour
{

    private GameObject da_chiudere;
    // Start is called before the first frame update
    void Start()
    {
        da_chiudere = GameObject.Find("Oggetti_Canvas");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Close()
    {
        Image[] ts = da_chiudere.gameObject.GetComponentsInChildren<Image>();
        foreach (Image t in ts)
        {
            if (t != null && t.gameObject != null)
                t.gameObject.GetComponent<Image>().enabled = false;
        }
        this.gameObject.GetComponent<Image>().enabled = false;
        this.gameObject.GetComponent<Button>().enabled = false;

    }
}
