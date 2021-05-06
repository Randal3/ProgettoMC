using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle : MonoBehaviour
{
    public GameObject pause;
    public GameObject joy;
    Toggle toggle;
    // Start is called before the first frame update
    void Start()
    {
        toggle = GetComponent<Toggle>();
    }
    void toggler(bool tog)
    {
        pause.SetActive(tog);
        joy.SetActive(!tog);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
