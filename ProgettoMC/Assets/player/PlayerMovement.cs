using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 0.15f;
    private Rigidbody2D myRigidbody;
    private Vector3 change;
    private Animator animator;
    private Joystick joystick;

    // Start is called before the first frame update
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        myRigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        change.x = joystick.Horizontal;
        change.y = joystick.Vertical;
        //change.x = Input.GetAxisRaw("Horizontal");
        //change.y = Input.GetAxisRaw("Vertical");
        if (change != Vector3.zero) {
            animator.SetFloat("X", change.x);
            animator.SetFloat("Y", change.y);
            movimento();
        }
        else
        {
            animator.SetBool("isMoving", false);

        }

    }
    
    private void movimento()
    {
        animator.SetBool("isMoving", true);
        myRigidbody.MovePosition(transform.position + change * speed);
         
    }
}
