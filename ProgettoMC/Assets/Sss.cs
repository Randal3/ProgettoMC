﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sss : MonoBehaviour
{
    private void OnMouseDown()
    {
        if(!Soluzione.youWin)
        transform.Rotate(0f, 0f, 90f);
    }
}