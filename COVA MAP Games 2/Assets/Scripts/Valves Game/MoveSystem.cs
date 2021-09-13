using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSystem : MonoBehaviour
{
    private float StartPosX;
    private float StartPosY;
    private float startx;
    private float starty;

    Collider other;

    public ValvesCSV ValvesCSVScript;

    public ScoringValves ScoringValvesScript;



    private void Start()
    {
        DontDestroy.NumberCorrect = 0;

    }

    private void OnMouseDown()
    {
        startx = transform.position.x;
        starty = transform.position.y;
        StartPosX = Cursor3D.Position.x - transform.position.x;
        StartPosY = Cursor3D.Position.y - transform.position.y;
    }
    private void OnMouseDrag()
    {
        //Debug.Log("mouse drag");
        Vector3 CurrentPos = transform.position;
        this.gameObject.transform.position = new Vector3(Cursor3D.Position.x - StartPosX, Cursor3D.Position.y - StartPosY, transform.position.z);
        //Debug.Log(Input.mousePosition.x);
    }
    private void OnMouseUp()
    {
        Debug.Log("mouse up");

       // OnTriggerEnter;

        this.gameObject.transform.position = new Vector3(startx, starty, transform.position.z);

        if (other != null)
        {
            ValveSpot spot = other.GetComponent<ValveSpot>();
            if (spot != null && spot.correctValves.Contains(gameObject))
            {
                // This is the right one
                Debug.Log("INDEXVALVE: " + ValvesCSVScript.indexValve);
                ValvesCSVScript.ValveSpotsList[ValvesCSVScript.indexValve].GetComponent<Collider>().enabled = false;
                //Make correct valve show


                DontDestroy.NumberCorrect = DontDestroy.NumberCorrect + 1;

                //Go to next discription
                ValvesCSVScript.DisplayCorrectValveDescription();

                ScoringValvesScript.GetScore();

                this.other = null;
            }
            else
            {
                // This is the wrong one
                Debug.Log("An X shows now. This is incorrect.");
                // Make X show

                DontDestroy.NumberTimesChecked = DontDestroy.NumberTimesChecked + 1;

                ScoringValvesScript.GetScore();

                //this.other = null;

            }
        }
    }
    
    void OnTriggerEnter(Collider other)
    {
        print("on trigger enterrrrr");
        Debug.Log(other.gameObject.name);
        this.other = other;
    }

    private void OnTriggerExit(Collider other)
    {
        this.other = null;
    }

}