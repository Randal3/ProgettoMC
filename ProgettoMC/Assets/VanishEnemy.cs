using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VanishEnemy : MonoBehaviour
{
    public float time;
    public GameObject enemy;
    private Animator animator;
    //per sapere se il mostro è attivo e spegnere le luci

    public MortePlayer fine;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        time += Time.deltaTime;
        if (time >= 15)
        {
            animator.SetBool("death", true);
            Invoke("Vanish", 1);
        }
    }
    void Vanish()
    {
        time = 0;
        enemy.SetActive(false);
        animator.SetBool("death", false);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            fine.Setup(Timer.v);
        }
    }
}
