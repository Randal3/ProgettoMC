using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    private void OnMouseDown()
    {
            transform.Rotate(0, 0, 90);
    }
}
