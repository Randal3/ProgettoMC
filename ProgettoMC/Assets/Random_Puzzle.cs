using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Puzzle : MonoBehaviour
{
    public Transform[] pictures;
    private int[] angle = { 0, 90, 180, 270 };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        for(int i = 0; i < 9; i++)
        {
            pictures[i].Rotate(0,0, angle[Random.Range(0, 3)]);
        }
    }
}
