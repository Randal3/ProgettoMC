using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimazioneCancello : MonoBehaviour
{
    public GameObject aperto;
    public GameObject chiuso;

    // Update is called once per frame
    void Update()
    {
        if ((BoxAppoggio.indovinelloFinito && Keypad.Finito) || DigitalDisplay.Finito)
        {
            Sound.Mauro("cancello");
            //SoundManager.PlaySound("cancello");
            aperto.SetActive(true);
            chiuso.SetActive(false);
        }
    }
}
