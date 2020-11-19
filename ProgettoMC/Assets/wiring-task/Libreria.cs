using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Libreria : MonoBehaviour
{
    private Animator animator;
    public GameObject key;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
            }

    // Update is called once per frame
    void Update()
    {
        if (Soluzione.youWin)
        {
            animator.SetBool("trovato", true);
            key.SetActive(true);
        }
     }
   
}
