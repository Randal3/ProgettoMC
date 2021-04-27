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

    public static event Action<string> ButtonPressed = delegate { };

    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(ButtonClicked);
    }
    private void ButtonClicked()
    {
        RaycastHit2D grabCheck = Physics2D.Raycast(boxDetect.position, Vector2.right * transform.localScale, rayDist);

        if (grabCheck.collider != null && grabCheck.collider.CompareTag("ChiaveAttiva"))
        {
                grabCheck.collider.gameObject.transform.parent = boxHolder;
                grabCheck.collider.gameObject.transform.position = boxHolder.position;
                grabCheck.collider.gameObject.transform.GetChild(0).GetComponent<BoxCollider2D>().isTrigger = true;
        }

      /*  else
        {
            grabCheck.collider.gameObject.transform.GetChild(0).GetComponent<BoxCollider2D>().isTrigger = false;
            grabCheck.collider.gameObject.transform.parent = null;
        }*/
    }
}