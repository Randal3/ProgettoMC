using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Sprite : MonoBehaviour
{
    public Animator animator;

    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if (collision.CompareTag("Player"))
        {
            animator.SetBool("isMoving", true);
            animator.SetFloat("X", 0);
            animator.SetFloat("Y", 1);
            
            Debug.Log("change");

        }
    }
}
