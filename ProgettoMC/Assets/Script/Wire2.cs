using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Wire2 : MonoBehaviour
{
    private LineRenderer line;
    public bool leftWire;
    private Canvas canvas;
    private bool isDrag = false;
    // Start is called before the first frame update
    void Start()
    {
        line = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDrag)
        {
            Vector2 movPos;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas.transform as RectTransform, Input.mousePosition, canvas.worldCamera, out movPos);
            line.SetPosition(0, transform.position);
            line.SetPosition(0, canvas.transform.TransformPoint(movPos));
        }
        
    }
    public void OnBeingDrag(PointerEventData eventData)
    {
        if (!leftWire) { return; }
        isDrag = true;
    }
    public void OnEndDragg(PointerEventData eventData)
    {
        isDrag = false;
    }
}
