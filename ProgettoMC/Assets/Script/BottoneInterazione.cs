using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class BottoneInterazione : MonoBehaviour
{
    public Transform boxDetect;
    public Transform boxHolder;
    public float rayDist;
    public static bool preso = false;
    public GameObject bottone;

    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(ButtonClicked);
    }
    private void ButtonClicked()
    {
        RaycastHit2D grabCheck = Physics2D.Raycast(boxDetect.position, Vector2.right * transform.localScale, rayDist);

        if (grabCheck.collider != null && grabCheck.collider.CompareTag("ChiaveAttiva"))
        {
            if (preso == false) {
                preso = true;
                grabCheck.collider.gameObject.transform.parent = boxHolder;
                grabCheck.collider.gameObject.transform.position = boxHolder.position;
                bottone.SetActive(true);
            }
            else
            {
                grabCheck.collider.gameObject.transform.parent = null;
                preso = false;
                bottone.SetActive(false);
            }
        }
    }
}