using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttone : MonoBehaviour
{
    public GameObject joystick;
    public GameObject player;
    public GameObject retur;        // tutti i buttoni 
    public GameObject Pausa;
    public GameObject Puzzle;
    public GameObject Pc;
    public GameObject Lavagna;
    public GameObject Wire;
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
                player.SetActive(false);
                gameObject.SetActive(false);
                break;
            case 2:
                Pc.SetActive(true);
                gameObject.SetActive(false);
                break;
            case 3:
                Lavagna.SetActive(true);
                joystick.SetActive(false);
                retur.SetActive(true);
                Pausa.SetActive(false);
                gameObject.SetActive(false);
                break;
            case 4:
                Debug.Log("33");
                Wire.SetActive(true);
                joystick.SetActive(false);
                retur.SetActive(true);
                Pausa.SetActive(false);
                player.SetActive(false);
                gameObject.SetActive(false);
                break;
        }
    }
     
}
