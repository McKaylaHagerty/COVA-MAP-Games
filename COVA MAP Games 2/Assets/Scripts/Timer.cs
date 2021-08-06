using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Timer : MonoBehaviour

{
    public Text text;
    public float timeLeft = 0.0f;

    public void Start()
    {
        if(DontDestroy.LevelChoice == "Easy")
        {
            timeLeft = 20.0f;
        }

        else if(DontDestroy.LevelChoice == "Medium")
        {
            timeLeft = 40.0f;
        }

        else if(DontDestroy.LevelChoice == "Hard")
        {
            timeLeft = 60.0f;
        }       
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;
        text.text = "Time Left: " + Mathf.Round(timeLeft);
        if(timeLeft < 0)
        {
            //check
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void ResumeGame ()
    {
        Time.timeScale = 1;
    }
}
