using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keypad : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Sprite[] digits;
    [SerializeField] private Image[] characters;
    public GameObject game;
    private string codeSequences;
    int j = 0;
    public Quadro_Randomico daDovePrendoSoluzione;
    private string soluzione;
    public GameObject enemy;
    public GameObject on;
    public GameObject off;
    public Transform spawn;
    

    private GameObject gestoreIndovinelli;
    public int numeroIndovinello;
    public FineGioco finegioco;

    void Start()
    {
        soluzione = daDovePrendoSoluzione.GetComponent<Quadro_Randomico>().getSoluzione();
        codeSequences = "";
        /* for (int i=0; i <= characters.Length - 1; i++)
         {
             characters[i].sprite = digits[5];
         }*/
        PushTheButton.ButtonPressed += AddDigitToCodeSequences;

        gestoreIndovinelli = GameObject.Find("RiddlesControl");
    }
    private void AddDigitToCodeSequences(string digitEntered)
    {
        Debug.Log("22");
        if (codeSequences.Length < 20)
        {
            switch (digitEntered)
            {
                case "0":
                    codeSequences += "0";
                    DisplayCodeSequence(0);
                    break;
                case "1":
                    codeSequences += "1";
                    DisplayCodeSequence(1);
                    break;
                case "2":
                    codeSequences += "2";
                    DisplayCodeSequence(2);
                    break;
                case "3":
                    codeSequences += "3";
                    DisplayCodeSequence(3);
                    break;
                case "4":
                    codeSequences += "4";
                    DisplayCodeSequence(4);
                    break;
                case "5":
                    codeSequences += "5";
                    DisplayCodeSequence(5);
                    break;
                case "6":
                    codeSequences += "6";
                    DisplayCodeSequence(6);
                    break;
                case "7":
                    codeSequences += "7";
                    DisplayCodeSequence(7);
                    break;
                case "8":
                    codeSequences += "8";
                    DisplayCodeSequence(8);
                    break;
                case "9":
                    codeSequences += "9";
                    DisplayCodeSequence(9);
                    break;
            
            }
        }

    }
    private void DisplayCodeSequence(int digitJustEntered)
    {
        if (j < 4)
        {
            characters[j].sprite = digits[digitJustEntered];

            j++;
        }
        if (j == 4)
        {
            CheckResults();
        }
    }
    private void CheckResults()
    {
        if (codeSequences == soluzione)
        {
            on.SetActive(true);
            Debug.Log("Correct!");
            Invoke("Correct", 0.5f);
        }
        else
        {
            off.SetActive(true);
            Invoke("ResetDisplay", 0.5f);
        }
    }
    private void Correct()
    {
        Luci.luci = true;
        game.SetActive(false);
        enemy.transform.position = spawn.transform.position;
        enemy.SetActive(true);

        gestoreIndovinelli.GetComponent<Gestore_Indovinelli>().setIndovinelli(numeroIndovinello);
        finegioco.GetComponent<FineGioco>().FinisciGioco();

    }
    private void ResetDisplay()
    {
        for (int i = 0; i <= characters.Length - 1; i++)
        {
            characters[i].sprite = digits[10];
        }
        codeSequences = "";
        off.SetActive(false);
        j = 0;
    }
    private void OnDestroy()
    {
        PushTheButton.ButtonPressed -= AddDigitToCodeSequences;
    }
}