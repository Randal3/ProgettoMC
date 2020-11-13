using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Close_Button : MonoBehaviour
{

    public GameObject canvas_object;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Close()
    {
        Image[] ts = canvas_object.gameObject.GetComponentsInChildren<Image>();
        foreach (Image t in ts)
        {
            if (t != null && t.gameObject != null)
                t.gameObject.GetComponent<Image>().enabled = false;
        }
        this.gameObject.SetActive(false);
    }
}
