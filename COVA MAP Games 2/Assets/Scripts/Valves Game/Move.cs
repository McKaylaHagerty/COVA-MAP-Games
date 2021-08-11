using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Move : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    bool isDragging;
 
    private void Update()
    {
        if (isDragging)
        {
            transform.position = Input.mousePosition;
        }
    }
 
    public void OnPointerDown(PointerEventData eventData)
    {
        RaycastHit2D hit = Physics2D.Raycast(eventData.position, Vector2.zero);
        if (hit.collider.name == "Draggable")
        {
            isDragging = true;
        }
    }
 
    public void OnPointerUp(PointerEventData eventData)
    {
        isDragging = false;
    }
}
