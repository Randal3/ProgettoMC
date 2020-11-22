using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Combinazione_Quadro : MonoBehaviour
{
    [SerializeField]
    Text codeText;
    string codeTextValue = "";
    public GameObject key;
    public Quadro_Randomico daDovePrendoSoluzione;
    private string soluzione;

    void Start()
    {
        soluzione = daDovePrendoSoluzione.GetComponent<Quadro_Randomico>().getSoluzione();   
    }

    // Update is called once per frame
    void Update()
    {
        codeText.text = codeTextValue;

        if (codeTextValue == soluzione)
        {
            key.gameObject.SetActive(true);
        }

        if (codeTextValue.Length >= 4)
            codeTextValue = "";
    }

    public void AddDigit(string digit)
    {
        codeTextValue += digit;
    }
}
