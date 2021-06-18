using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
  
    void Update()
    {
        Invoke("Rain", 0.5f);
    }
    public void Rain()
    {
        Destroy(gameObject);
    }
}
