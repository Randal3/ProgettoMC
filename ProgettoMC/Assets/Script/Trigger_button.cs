using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger_button : MonoBehaviour
{
    public GameObject game;
    public GameObject but_ret; //pulsante di return
    private GameObject joystick;
    public Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        joystick = GameObject.FindGameObjectWithTag("joystick");
        gameObject.GetComponent<Button>().onClick.AddListener(ButtonClicked);
    }

    private void ButtonClicked()
    {
        but_ret.SetActive(true);
        game.SetActive(true);
        camera.enabled = false;
        joystick.SetActive(false);
        gameObject.SetActive(false);
    }
}
