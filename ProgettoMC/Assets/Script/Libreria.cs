using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Libreria : MonoBehaviour
{
    private Animator animator;
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public GameObject box;
    private bool i = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Soluzione.youWin == true && i==false)
        {
            i = true;
            Invoke("Active", 1);
            
        }
    }
    void Active()
    {
        SoundManager.PlaySound("libreria");
        animator.SetBool("trovato", true);
        spriteRenderer.sprite = newSprite;
        animator.enabled = false;
        box.SetActive(true);
    }
}
