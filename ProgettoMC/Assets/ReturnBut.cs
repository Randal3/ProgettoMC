using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReturnBut : MonoBehaviour
{
    public GameObject joystick;
    public GameObject retur;
    public GameObject player;
    public GameObject Wire;             // tutti i buttoni 
    public GameObject Pausa;
    public GameObject Puzzle;
    public GameObject Pc;
    public GameObject Lavagna;
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(ButtonClicked);
    }

    private void ButtonClicked()
    {

        switch (Trigger.n)
        {
            case 1:
                Puzzle.SetActive(false);
                player.SetActive(true);
                joystick.SetActive(true);
                retur.SetActive(false);
                Pausa.SetActive(true);
                break;
            case 2:
                Pc.SetActive(false);
                joystick.SetActive(true);
                retur.SetActive(false);
                Pausa.SetActive(true);
                break;
            case 3:
                Lavagna.SetActive(false);
                joystick.SetActive(true);
                retur.SetActive(false);
                Pausa.SetActive(true);
                break;
            case 4:
                Wire.SetActive(false);
                player.SetActive(true);
                joystick.SetActive(true);
                retur.SetActive(false);
                Pausa.SetActive(true);
                break;
        }
    }
}
