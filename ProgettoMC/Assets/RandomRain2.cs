using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRain2 : MonoBehaviour
{
    public GameObject rain;
    private GameObject rainclone;
    public GameObject container;
    int i = 0;
    private float InstantiationTimer = 0.5f;
    // Start is called before the first frame update
    Vector2 randomVec;


    // Update is called once per frame
    void Update()
    {
        i++;
        randomVec = new Vector2(Random.Range(29, 60), Random.Range(-57, -20));
        rainclone = Instantiate(rain, randomVec, Quaternion.identity);
        rainclone.transform.parent = container.transform;
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
