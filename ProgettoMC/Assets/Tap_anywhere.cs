using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Tap_anywhere : MonoBehaviour
{
    public GameObject Menu;
    public GameObject Tap;
    public Text text;
    public Animator splash;
    float timer;
    
   
    // Update is called once per frame
    void Update()
    {
        timer +=  Time.deltaTime;
        if (timer >= 0.3)
        {
            text.enabled = true;
        }
        if (timer >= 0.8)
        {
           text.enabled = false;
            timer = 0;
        }

        if (Input.touchCount > 0 || Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Bella");
            splash.SetTrigger("splash");
            Invoke("Aiuto", 1);
        }    }
    void Aiuto()
    {
        
        Tap.SetActive(false);
        Menu.SetActive(true);
        
    }
}
