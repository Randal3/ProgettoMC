using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VanishEnemy : MonoBehaviour
{
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        while (gameObject.activeInHierarchy)
        {
            time += Time.deltaTime;
            Debug.Log(time);
        }
        time = 0;
        
    }
}
