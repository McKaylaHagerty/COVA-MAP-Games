using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSystem : MonoBehaviour
{

    public GameObject correctForm;
    private bool moving;

    private float StartPosX;
    private float StartPosY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if(moving)
        // {
        //     Vector3 MousePos;
        //     MousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y, 10.0f));
        //     this.gameObject.transform.position = new Vector3(MousePos.x - StartPosX, MousePos.y - StartPosY, 10.0f);
        //     Debug.Log(Input.mousePosition.x);
        // }
    }

    private void OnMouseDown()
    {
        // if(Input.GetMouseButtonDown(0))
        // {
            Vector3 MousePos;
            MousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y, 10.0f));

            StartPosX = MousePos.x - transform.position.x;
            StartPosY = MousePos.y - transform.position.y;

            moving = true;
        //}
    }
    private void OnMouseDrag()
    {
            Vector3 MousePos;
            MousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y, 10.0f));
            this.gameObject.transform.position = new Vector3(MousePos.x - StartPosX, MousePos.y - StartPosY, 10.0f);
            Debug.Log(Input.mousePosition.x);
    }

    private void OnMouseUp()
    {
        moving = false;
        Debug.Log("mouse up");
    }
}
