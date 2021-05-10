using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambioStanza : MonoBehaviour
{
    public Vector3 playerChange;
    public GameObject Attivazione; 
    public GameObject Disattivazione;
    public GameObject Luce;

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
        if (collision.CompareTag("Player") || collision.CompareTag("enemy"))
        {
            collision.transform.position += playerChange;
            Attivazione.SetActive(true);
            Disattivazione.SetActive(false);
            if (Luci.luci == false)
            {
                Luce.SetActive(true);
                Debug.Log("Luceeee");
            }
                
        }
    }

}
