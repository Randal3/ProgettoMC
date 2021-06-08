using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Return_button : MonoBehaviour
{
    public GameObject game;
    public GameObject joystick;
    public Camera camera1;
    // Start is called before the first frame update
    void Start()
    {
        
        gameObject.GetComponent<Button>().onClick.AddListener(ButtonClicked);
    }

    private void ButtonClicked()
    {
        game.SetActive(false);
        camera1.enabled = true;
        joystick.SetActive(true);
        gameObject.SetActive(false);
    }
}
