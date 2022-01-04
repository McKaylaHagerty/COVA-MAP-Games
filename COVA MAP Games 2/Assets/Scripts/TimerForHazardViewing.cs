using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class TimerForHazardViewing : MonoBehaviour

{
    public float timeStart = 3.0f;
    public float timeLeftToView = 0.0f;

    //Referencing other scripts.

    public void Start()
    {
        if (DontDestroy.LevelChoice == "Easy")
        {
            timeStart = 20.0f;
        }

        else if (DontDestroy.LevelChoice == "Medium")
        {
            timeStart = 15.0f;
        }

        else if (DontDestroy.LevelChoice == "Hard")
        {
            DontDestroy.timeLeft = 5.0f;  //To be changed back to 20.0
        }

        Time.timeScale = 1;
        timeLeftToView = timeStart;
        print("time is starting");
    }

    public void Update()
    {
        timeLeftToView -= 1 * Time.deltaTime;
        if(timeLeftToView<=0)
        {
            print("time is up!!!!!");
            SceneManager.LoadScene("HazardsChecklist");
        }
        
    }

   
}

