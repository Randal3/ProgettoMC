using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text TimerText;
    private float startTime;

    public static string v;

    public MortePlayer fine;
    public static bool Freeze = true;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }
    public void Awake()
    {
        Freeze = true;
    }
    // Update is called once per frame
    void Update()
    {
        
        if (Timer.Freeze == true)
        {
            float t = Time.time - startTime;
            float minutes = Mathf.FloorToInt(t / 60);
            float seconds = Mathf.FloorToInt(t % 60);
            v = string.Format("{0:00}:{1:00}", minutes, seconds);
            TimerText.text = v;
        }
    }
}
