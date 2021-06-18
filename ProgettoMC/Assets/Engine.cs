using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Engine : MonoBehaviour
{
    public GameObject player;
    public GameObject joystick;
    public GameObject Pause;
    public GameObject Wire;
    public AudioSource alarm;
    public GameObject Return;
    public static bool wire = true;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(ButtonClicked);
    }

    // Update is called once per frame
    private void ButtonClicked()
    {
        if (Wire_Game.Instance.but)
        {
            alarm.Stop();
            Luci.luci = false;
            Pause.SetActive(true);
            joystick.SetActive(true);
            player.SetActive(true);
            Wire.SetActive(false);
            Return.SetActive(false);
            wire = false;
            Wire_Game.Instance.Restart();
            Wire_Game.Instance.Clone();
        }
    }
   }
