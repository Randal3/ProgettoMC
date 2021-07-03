using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Libreria : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public GameObject box;
    private bool i = true;


    void Update()
    {
        if (Soluzione.youWin && i == true) { 
        spriteRenderer.sprite = newSprite;
        box.SetActive(true);
        i = false;
        }
    }
}
