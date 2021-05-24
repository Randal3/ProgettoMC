using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tempoFinale : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        text.text = FineGioco.tempoFinale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
