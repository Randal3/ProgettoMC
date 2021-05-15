using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VanishEnemy : MonoBehaviour
{
    public float time;
    public GameObject enemy;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
            time += Time.deltaTime;
            Debug.Log(time);
        if (time >= 15)
        {
            animator.SetBool("death", true);
            Invoke("Vanish", 2);
        }
    }
    void Vanish()
    {
        time = 0;
        enemy.SetActive(false);
        animator.SetBool("death", false);
    }
}
