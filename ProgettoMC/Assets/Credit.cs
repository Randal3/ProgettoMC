using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class Credit : MonoBehaviour
{
    public GameObject Credito;
    public GameObject Video;
    public GameObject Logo;


    private VideoPlayer videos;
    private Animator credits;
    private Animator logos;
    // Start is called before the first frame update
    void Start()
    {
        videos = Video.GetComponent<VideoPlayer>();
        credits = Credito.GetComponent<Animator>();
        logos = Logo.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Awake()
    {
        Invoke("ToBeContinued", 19f);
    }
    void ToBeContinued()
    {
        videos.Play();
        Invoke("ThankU", 19.5f);
        
    }
    void ThankU()
    {
        logos.SetTrigger("logo");
        Invoke("Menu", 5);
    }
    void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
