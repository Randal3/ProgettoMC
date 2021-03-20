 using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    bool gameHasEnded = false;
    public GameObject convas;
   
    public void EndGAme()
    {
        if(gameHasEnded == false)
        {
            convas.SetActive(true);
            
            gameHasEnded = true;
            Debug.Log("Game Over");
            

            Invoke("Restart", 4);
        }
    }
    void Restart()
    {
        
        SceneManager.LoadScene("SampleScene");
    }
}
