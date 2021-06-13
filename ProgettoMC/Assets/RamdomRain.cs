using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RamdomRain : MonoBehaviour
{
    public GameObject rain;
    private GameObject rainclone;
    int i=0;
    private float InstantiationTimer = 0.5f;
    // Start is called before the first frame update
    Vector2 randomVec;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        i++;
            randomVec = new Vector2(Random.Range(-10, 10), Random.Range(-10, 10));
             rainclone = Instantiate(rain, randomVec, Quaternion.identity);
        rainclone.SetActive(true);
            rainclone.name = "rainClone" + i;
        //Invoke("RainDestroy", 0.2f);
        
     }
  /*  public void RainDestroy()
    {

            Debug.Log("fatto"+i);
            Destroy(rainclone);
            Debug.Log("fatto");
        
    }*/
}
