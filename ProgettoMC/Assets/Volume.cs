using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Volume : MonoBehaviour
{
    // public AudioMixer audiomixer;
    public AudioSource Audio;

    void Start()
    {
        Audio = GetComponent<AudioSource>();
    }

    public void SetVolume(float volume)
    {
        //audiomixer.SetFloat("volume", volume);
        Audio.volume = volume;
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
