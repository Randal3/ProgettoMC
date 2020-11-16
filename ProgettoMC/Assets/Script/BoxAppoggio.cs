using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxAppoggio : MonoBehaviour
{
    public GameObject chiave;
    public Transform holder;
    public string Tag;
    public string nuovoTag;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Y))
        {
            if(holder.transform.childCount == 3 && holder.transform.GetChild(0).gameObject.transform.tag == nuovoTag && holder.transform.GetChild(1).gameObject.transform.tag == nuovoTag)
            {
                chiave.SetActive(true);
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(Tag))
        {
            collision.gameObject.tag = nuovoTag;
            collision.gameObject.transform.parent = holder;
            collision.gameObject.transform.position = holder.position;
        }
    }
}
