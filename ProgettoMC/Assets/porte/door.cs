using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    private Animator animator;
    private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float y = target.position.y;
        float x = target.position.x;
        if (y > 3 && y < 9.5 && x > 20 && x < 24.2)
        {
            animator.SetBool("open", true);
        }
        else
        {
            animator.SetBool("open", false);
        }
    }
}
