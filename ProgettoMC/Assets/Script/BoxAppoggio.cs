using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxAppoggio : MonoBehaviour
{
    public Transform holder;
    public string Tag;
    public string nuovoTag;

    // Update is called once per frame
    void Update()
    {
        if (holder.transform.parent == null)
        {
            Debug.Log("La chiave ci sta");
        }
        else
        {
            Debug.Log("La chiave NO");
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
