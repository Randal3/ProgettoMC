using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Combinazione_Quadro : MonoBehaviour
{
    [SerializeField]
    Text codeText;
    string codeTextValue = "";

    //public GameObject key;

    public Quadro_Randomico daDovePrendoSoluzione;
    private string soluzione;

    private GameObject gestoreIndovinelli;
    public int numeroIndovinello;

    public GameObject enemy;
    public Transform spawn;

    public FineGioco finegioco;

    void Start()
    {
        gestoreIndovinelli = GameObject.Find("RiddlesControl");
        soluzione = daDovePrendoSoluzione.GetComponent<Quadro_Randomico>().getSoluzione(); 
    }

    // Update is called once per frame
    void Update()
    {
        codeText.text = codeTextValue;

        if (codeTextValue == soluzione)
        {
            enemy.transform.position = spawn.transform.position;
            enemy.SetActive(true);
            //key.gameObject.SetActive(true);
            Luci.luci = true;
            gestoreIndovinelli.GetComponent<Gestore_Indovinelli>().setIndovinelli(numeroIndovinello);
            finegioco.GetComponent<FineGioco>().FinisciGioco();
        }

        if (codeTextValue.Length >= 4)
            codeTextValue = "";
    }

    public void AddDigit(string digit)
    {
        codeTextValue += digit;
    }
}
