using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public Animator pausa;
    
    // Start is called before the first frame update
    public void Quit()
    {
        Timer.Freeze = false;
        Time.timeScale = 1;

        Debug.Log("Quit:"+Time.timeScale);
        SceneManager.LoadScene("Menu");
        
    }

    // Update is called once per frame

    private void Update()
    {
        if (gameObject.activeSelf == true)
        {
            Debug.Log("sono attivo");
            Debug.Log("Update:"+Time.timeScale);
            pausa.SetTrigger("start");
            Timer.Freeze = false;
            Time.timeScale = 0;
        }
    }
    public void Resume()
    {
        Timer.Freeze = true;
        Time.timeScale = 1;
    }
}
