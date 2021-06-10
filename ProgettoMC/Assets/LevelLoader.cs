using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator splash;
    public float transitionTime = 1f;
    bool second=true;

    void Update()
    {
        
        if (SceneManager.GetActiveScene().name == "SampleScene" && second)
        {
            
            splash.SetTrigger("transition");
            second = false;
    }
    }
    public void LoadGame()
    {
        Debug.Log("Bello");
        splash.SetTrigger("start");
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }
    IEnumerator LoadLevel(int levelIndex)
    {
        
        yield return new WaitForSeconds(transitionTime);
        second = true;
        
        SceneManager.LoadScene(levelIndex);


    }
}
