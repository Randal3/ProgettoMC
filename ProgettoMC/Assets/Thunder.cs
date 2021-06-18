using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thunder : MonoBehaviour
{
    public bool isFlickering = false; 
    public float timeDelay;
    public GameObject thunder;
    private float time;
    private float spawntime;
    void Update()
    {
        time += Time.deltaTime;
        Debug.Log("spawn: " + spawntime);
        if ((time>=spawntime))
        {
            Debug.Log("Thunder");
            StartCoroutine(FlickeringLight());
        }
    }
    IEnumerator FlickeringLight()
    {
        time = 0;
        thunder.SetActive(false);
        timeDelay = Random.Range(0.05f, 0.4f);
        yield return new WaitForSeconds(timeDelay);
        thunder.SetActive(true);
        timeDelay = Random.Range(0.05f, 0.4f);
        yield return new WaitForSeconds(timeDelay);
        thunder.SetActive(false);
        spawntime = Random.Range(0.5f, 5);

    }
}
