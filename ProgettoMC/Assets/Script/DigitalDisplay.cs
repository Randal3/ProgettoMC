using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DigitalDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Sprite[] digits;
    [SerializeField] private Image[] characters;
    public GameObject game;
    private string codeSequences;
    int j = 0;
    void Start()
    {
        codeSequences = "";
       /* for (int i=0; i <= characters.Length - 1; i++)
        {
            characters[i].sprite = digits[5];
        }*/
        PushTheButton.ButtonPressed += AddDigitToCodeSequences;
    }
    private void AddDigitToCodeSequences(string digitEntered)
    {
        if (codeSequences.Length < 20)
        {
            switch (digitEntered)
            {
                case "A":
                    codeSequences += "0";
                    DisplayCodeSequence(0);
                    break;
                case "B":
                    codeSequences += "1";
                    DisplayCodeSequence(1);
                    break;
                case "C":
                    codeSequences += "2";
                    DisplayCodeSequence(2);
                    break;
                case "D":
                    codeSequences += "3";
                    DisplayCodeSequence(3);
                    break;
                case "E":
                    codeSequences += "4";
                    DisplayCodeSequence(4);
                    break;
                case "F":
                    codeSequences += "5";
                    DisplayCodeSequence(5);
                    break;
                case "G":
                    codeSequences += "6";
                    DisplayCodeSequence(6);
                    break;
                case "H":
                    codeSequences += "7";
                    DisplayCodeSequence(7);
                    break;
                case "I":
                    codeSequences += "8";
                    DisplayCodeSequence(8);
                    break;
                case "L":
                    codeSequences += "9";
                    DisplayCodeSequence(9);
                    break;
                case "M":
                    codeSequences += "10";
                    DisplayCodeSequence(10);
                    break;
                case "N":
                    codeSequences += "11";
                    DisplayCodeSequence(11);
                    break;
                case "O":
                    codeSequences += "12";
                    DisplayCodeSequence(12);
                    break;
                case "P":
                    codeSequences += "13";
                    DisplayCodeSequence(13);
                    break;
                case "Q":
                    codeSequences += "14";
                    DisplayCodeSequence(14);
                    break;
                case "R":
                    codeSequences += "15";
                    DisplayCodeSequence(15);
                    break;
                case "S":
                    codeSequences += "16";
                    DisplayCodeSequence(16);
                    break;
                case "T":
                    codeSequences += "17";
                    DisplayCodeSequence(17);
                    break;
                case "U":
                    codeSequences += "18";
                    DisplayCodeSequence(18);
                    break;
                case "V":
                    codeSequences += "19";
                    DisplayCodeSequence(19);
                    break;
                case "Z":
                    codeSequences += "20";
                    DisplayCodeSequence(20);
                    break;
            }
        }
        
    }
    private void DisplayCodeSequence(int digitJustEntered)
    {
        if (j < 10)
        {
            characters[j].sprite = digits[digitJustEntered];
            Debug.Log(digitJustEntered);
            j++;
        }
        if (j == 10)
        {
            CheckResults();
        }
    }
    private void CheckResults()
    {
        if (codeSequences == "10013130101211312" )
        {
            Debug.Log("Correct!");
            game.SetActive(false);
        }
        else
        {
            Debug.Log("Wrong!");
            ResetDisplay();
        }
    }
    private void ResetDisplay()
    {
        for (int i = 0; i <= characters.Length - 1; i++)
        {
            characters[i].sprite = digits[21];
        }
        codeSequences = "";
        j = 0;
    }
    private void OnDestroy()
    {
        PushTheButton.ButtonPressed -= AddDigitToCodeSequences;
    }
}