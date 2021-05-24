using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public static bool Freeze = true;
    // Start is called before the first frame update
    public void Quit()
    {
        SceneManager.LoadScene("Menu");
    }

    // Update is called once per frame
    void Awake()
    {
        Freeze = false;
        Time.timeScale = 0;
    }
    public void Resume()
    {
        Freeze = true;
        Time.timeScale = 1;
    }
}
