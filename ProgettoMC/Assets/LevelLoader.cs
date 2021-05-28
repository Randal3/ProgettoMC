using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator splash;
    public float transitionTime = 1f;
    
    public void LoadGame()
    {
        Debug.Log("Bello");
        splash.SetTrigger("transition");
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }
    IEnumerator LoadLevel(int levelIndex)
    {
        
        yield return new WaitForSeconds(transitionTime);
        
        SceneManager.LoadScene(levelIndex);

    }
}
