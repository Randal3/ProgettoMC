using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wire_Game : MonoBehaviour
{
    static public Wire_Game Instance;
    public  GameObject left;
    public  GameObject right;
    private  GameObject rightc;
    private  GameObject leftc;
    public  GameObject cointer;

    public bool but = false;

    public bool win = false;
    public int switchCount;
    //public GameObject winText;
    private int onCount = 0;
    void Awake()
    {
        Instance = this;
        Clone();
    }
   
    public void SwitchChange(int points)
    {
        onCount = onCount + points;
       
    }
    public void ToggleAnalog()
    {
        if (onCount == switchCount)
            but = !but;
        Debug.Log(but);
    }
     void Update()
    {
        if (onCount == switchCount && but == true)
        {
            win = true;
            Debug.Log("U WIN");
            Luci.luci = false;
            but = false;
            onCount = 0;
        }
    }
    public void Clone()
    {
            Debug.Log("SEi forte");
            rightc= Instantiate(right,right.transform.position, right.transform.localRotation);
            leftc = Instantiate(left,left.transform);
            rightc.transform.parent = cointer.transform;
            leftc.transform.parent = cointer.transform;
            rightc.transform.localScale = new Vector3(1, 1, 1);
            rightc.SetActive(true);
            leftc.SetActive(true);
        win = false;
    }
    public  void Restart()
    {
        Destroy(rightc);
        Destroy(leftc);
    }
}
