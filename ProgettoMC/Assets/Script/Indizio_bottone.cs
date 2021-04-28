using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Indizio_bottone : MonoBehaviour
{
    public GameObject game;
    public Camera camera;
    public bool playerInrange;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(ButtonClicked);
    }

    private void ButtonClicked()
    {
        game.SetActive(true);
        camera.enabled = false;
    }
    }
