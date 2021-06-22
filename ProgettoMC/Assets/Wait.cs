using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class Wait : MonoBehaviour
{
    public float wait_intro = 5f;
    public float wait_cuffie = 4.5f;
    public VideoPlayer cuffie;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait_for_intro());
    }
    IEnumerator Cuffie_intro()
    {
        cuffie.Play();
        yield return new WaitForSeconds(wait_cuffie);
        SceneManager.LoadScene("Menu");
    }
    IEnumerator Wait_for_intro()
    {
        yield return new WaitForSeconds(wait_intro);
        StartCoroutine(Cuffie_intro());
    }
    
}
