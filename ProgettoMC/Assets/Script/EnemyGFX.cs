using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyGFX : MonoBehaviour
{
    public AIPath aipath;
    public float speed = 5f;
    // Update is called once per frame
    void Update()
    {
        Debug.Log(aipath.desiredVelocity);
        /*if (aipath.desiredVelocity.x <= 0.01f)
        {
            //transform.localScale = new Vector3(-1f, 1f, 1f);
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        if (aipath.desiredVelocity.x >= -0.01f)
        {
            //transform.localScale = new Vector3(1f, 1f, 1f);
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
         if (aipath.desiredVelocity.y >= 0.01f)
        {
            //transform.localScale = new Vector3(1f, 1f, 1f);
            transform.rotation = Quaternion.Euler(0f, 0f, 90f);
        }
         if (aipath.desiredVelocity.y <= -0.01f)
        {
            //transform.localScale = new Vector3(1f, 1f, 1f);
            transform.rotation = Quaternion.Euler(0f, 0f, 270f);
        }*/
        float angle = Mathf.Atan2(aipath.desiredVelocity.y, aipath.desiredVelocity.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);
    }
}
