using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambioStanza : MonoBehaviour
{
    public Vector3 playerChange;
    public GameObject stanza1; 
    public GameObject stanza2;

    // Start is called before the first frame update
    void Start()
    {
        //box.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.position += playerChange;
            stanza1.SetActive(true);
            stanza2.SetActive(false);
        }
    }

}
