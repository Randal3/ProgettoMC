using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator splash;
    public Animator fade;
    public float transitionTime = 1f;
    bool second=true;

    void Update()
    {
        
        if (SceneManager.GetActiveScene().name == "SampleScene" && second)
        {
            Debug.Log(SceneManager.GetActiveScene().name);
            splash.SetTrigger("transition");
            second = false;
    }
    }
    public void LoadGame()
    {
        Debug.Log("Bello");
        splash.SetTrigger("start");
        fade.SetTrigger("Fade");
        
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }
    IEnumerator LoadLevel(int levelIndex)
    {
        
        yield return new WaitForSeconds(transitionTime);
        second = true;
        Debug.Log("second");
        SceneManager.LoadScene(levelIndex);


    }
}
