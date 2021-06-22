using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Libreria : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public GameObject box;
  

    void Awake()
    {
        spriteRenderer.sprite = newSprite;
        box.SetActive(true);
    }
}
