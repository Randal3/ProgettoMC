using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class Capture : MonoBehaviour
{
    public Button screen;
    void Start()
    {
        screen.onClick.AddListener(ScreenShot);
    }
    public void ScreenShot()
    {
       // Directory.CreateDirectory(Application.persistentDataPath + "/appScreenshots");
        ScreenCapture.CaptureScreenshot("pippo.png",2);
        string destinazione = Path.Combine(Application.persistentDataPath, "pippo.png");
        Debug.Log(destinazione);
    }
}
