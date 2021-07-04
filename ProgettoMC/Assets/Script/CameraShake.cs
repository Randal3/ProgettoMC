using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    Vector3 cameraPosition;
    public float ShakeMagnitude = 0.05f, ShakeTime = 0.5f;
    public Camera maincamera;
    public GameObject enemy;
    public Transform spawn;


    public void Shakeit()
    {
        cameraPosition = maincamera.transform.position;
        InvokeRepeating("StartCameraShaking", 0f, 0.005f);
        Invoke("StopCameraShaking", ShakeTime);
        enemy.transform.position = spawn.transform.position;
        enemy.SetActive(true);
    }

    void StartCameraShaking()
    {
        Debug.Log("S");
        float cameraShakingOffsetY = Random.value * ShakeMagnitude * 2 - ShakeMagnitude;
        float cameraShakingOffsetX = Random.value * ShakeMagnitude * 2 - ShakeMagnitude;
        Vector3 cameraIntermadiatePosition = maincamera.transform.position;
        cameraIntermadiatePosition.x += cameraShakingOffsetX;
        cameraIntermadiatePosition.y += cameraShakingOffsetY;
        maincamera.transform.position = cameraIntermadiatePosition;
    }
    void StopCameraShaking()
    {
        CancelInvoke("StartCameraShaking");
        maincamera.transform.position = cameraPosition;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && BoxAppoggio.indovinelloFinito && DigitalDisplay.Finito && Keypad.Finito)
        {
            Invoke("Shakeit", 0.5f);
        }
    }
}
