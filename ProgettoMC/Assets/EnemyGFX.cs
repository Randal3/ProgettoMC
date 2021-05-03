using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyGFX : MonoBehaviour
{
    public AIPath aipath;

    // Update is called once per frame
    void Update()
    {
        if (aipath.desiredVelocity.x <= 0.01f)
        {
            //transform.localScale = new Vector3(-1f, 1f, 1f);
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        else if (aipath.desiredVelocity.x >= -0.01f)
        {
            //transform.localScale = new Vector3(1f, 1f, 1f);
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
    }
}
