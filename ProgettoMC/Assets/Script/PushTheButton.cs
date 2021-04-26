using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PushTheButton : MonoBehaviour
{
    public static event Action<string> ButtonPressed = delegate { };
    private string buttonName;

    void Start()
    {
        buttonName = gameObject.name;
        gameObject.GetComponent<Button>().onClick.AddListener(ButtonClicked);
    }
    private void ButtonClicked() {
        ButtonPressed(buttonName);
    }
}
