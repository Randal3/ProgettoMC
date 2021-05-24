﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text TimerText;
    private float startTime;

    public FineGioco fine;
    public static bool Freeze = true;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Timer.Freeze);
        if (Timer.Freeze == true)
        {
            float t = Time.time - startTime;
            string minutes = ((int)t / 60).ToString();
            string seconds = (t % 60).ToString("f2");
            TimerText.text = minutes + ":" + seconds;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("enemy"))
        {
            string tempo = TimerText.ToString();
            Debug.Log("sei morto");
            fine.Setup(tempo);
        }
    }
}
