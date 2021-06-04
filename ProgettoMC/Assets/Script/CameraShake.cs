using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    Vector3 cameraPosition,canvasPosition;
    public float ShakeMagnitude = 0.05f, ShakeTime = 0.5f;
    public Camera maincamera;
    public GameObject mycanvas;
    public void Shakeit(){
        cameraPosition = maincamera.transform.position;
        canvasPosition = mycanvas.transform.position;
        InvokeRepeating("StartCameraShaking", 0f, 0.005f);
        Invoke("StopCameraShaking", ShakeTime);
    }
    void StartCameraShaking()
    {
        Debug.Log("S");
        float cameraShakingOffsetY = Random.value * ShakeMagnitude * 2 - ShakeMagnitude;
        float cameraShakingOffsetX = Random.value * ShakeMagnitude * 2 - ShakeMagnitude;
        float canvasShakingOffsetY = Random.value * ShakeMagnitude * 2 - ShakeMagnitude;
        float canvasShakingOffsetX = Random.value * ShakeMagnitude * 2 - ShakeMagnitude;
        Vector3 cameraIntermadiatePosition = maincamera.transform.position;
        Vector3 canvasIntermadiatePosition = mycanvas.transform.position;
        canvasIntermadiatePosition.x += canvasShakingOffsetX;
        canvasIntermadiatePosition.y += canvasShakingOffsetY;
        cameraIntermadiatePosition.x += cameraShakingOffsetX;
        cameraIntermadiatePosition.y += cameraShakingOffsetY;
        maincamera.transform.position = cameraIntermadiatePosition;
        mycanvas.transform.position = canvasIntermadiatePosition;
    }
    void StopCameraShaking()
    {
        CancelInvoke("StartCameraShaking");
        maincamera.transform.position = cameraPosition;
        mycanvas.transform.position = canvasPosition;
    }
}
