using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReturnBut : MonoBehaviour
{
    public GameObject joystick;
    public GameObject retur;        // tutti i buttoni 
    public GameObject Pausa;
    public GameObject Puzzle;
    public GameObject Pc;
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
        }
    }
}
