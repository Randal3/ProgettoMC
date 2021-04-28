using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    private void OnMouseDown()
    {
            Debug.Log("2");
            transform.Rotate(0, 0, 90);
    }
}
