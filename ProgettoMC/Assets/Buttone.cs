using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttone : MonoBehaviour
{
    public GameObject joystick;
    public GameObject retur;        // tutti i buttoni 
    public GameObject Pausa;
    public GameObject Puzzle;
    public GameObject Pc;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(ButtonClicked);
    }

    private void ButtonClicked()
    {
        switch (Trigger.n)
        {
            case 1:
                Puzzle.SetActive(true);
                joystick.SetActive(false);
                retur.SetActive(true);
                Pausa.SetActive(false);
                gameObject.SetActive(false);
                break;
            case 2:
                Pc.SetActive(true);
                joystick.SetActive(false);
                retur.SetActive(true);
                Pausa.SetActive(false);
                gameObject.SetActive(false);
                break;
        }
    }
     
}
