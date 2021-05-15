using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyGFX : MonoBehaviour
{
    public AIPath aipath;
    public float time;
    private float speed = 5f;
    // Update is called once per frame
    void Update()
    {
        float angle = Mathf.Atan2(aipath.desiredVelocity.y, aipath.desiredVelocity.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);
    }
}
