using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wire_Game : MonoBehaviour
{
    static public Wire_Game Instance;
    public  bool but = false;
    public int switchCount;
    //public GameObject winText;
    private int onCount = 0;

    private void Awake()
    {
        Instance = this;
    }
   
    public void SwitchChange(int points)
    {
        onCount = onCount + points;
       
    }
    public void ToggleAnalog()
    {
        if (onCount == switchCount)
            but = !but;
    }
    private void Update()
    {
        if (onCount == switchCount && but == true)
        {
            //winText.SetActive(true);
            Debug.Log("U WIN");
            Luci.luci = false;
        }
    }
}
