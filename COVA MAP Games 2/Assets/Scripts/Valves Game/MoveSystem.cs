using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSystem : MonoBehaviour
{
    private float StartPosX;
    private float StartPosY;
    private float startx;
    private float starty;

    private void OnMouseDown()
    {
        startx = transform.position.x;
        starty = transform.position.y;
        StartPosX = Cursor3D.Position.x - transform.position.x;
        StartPosY = Cursor3D.Position.y - transform.position.y;
    }
    private void OnMouseDrag()
    {
        Debug.Log("mouse drag");
        Vector3 CurrentPos = transform.position;
        this.gameObject.transform.position = new Vector3(Cursor3D.Position.x - StartPosX, Cursor3D.Position.y - StartPosY, transform.position.z);
        Debug.Log(Input.mousePosition.x);
    }
    private void OnMouseUp()
    {
        this.gameObject.transform.position = new Vector3(startx, starty, transform.position.z);
    }
}
