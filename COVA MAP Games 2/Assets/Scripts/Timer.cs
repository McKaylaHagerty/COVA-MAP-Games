using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Timer : MonoBehaviour

{
    public Text text;   //Timer text.
    public float timeLeft = 0.0f;

    //Referencing other scripts.
    public CheckAnswersPPE CheckAnswersPPEScript;  
    public ScoringPPE ScoringPPEScript;

    public GameObject NextButtonPanel; 
    public GameObject CheckButtonPanel;
    public GameObject[] LeftRightButtons;  //Array of the buttons that allow the user to switch between PPE.

    public void Start()
    {
        CheckButtonPanel.SetActive(true);   //Check button is active to start. Will disappear when time runs out.
        NextButtonPanel.SetActive(false);    //Next button is inactive to start. Will appear when time runs out.

        foreach(GameObject x in LeftRightButtons)  //All the buttons that allow the user to switch between PPE are active to start. Will disappear when time runs out.
        {
            x.SetActive(true);
        }

        //Choose time allowed based on level choice.

        if(DontDestroy.LevelChoice == "Easy")
        {
            timeLeft = 60.0f;
        }

        else if(DontDestroy.LevelChoice == "Medium")
        {
            timeLeft = 40.0f;
        }

        else if(DontDestroy.LevelChoice == "Hard")
        {
            timeLeft = 5.0f;  //To be changed back to 20.0
        }       
    }

    bool Checked = false;  //Bool need to use as a condition to stop the update method.
    public void Update()  //Timer counts down in seconds.
    {
        timeLeft -= Time.deltaTime;
        text.text = "Time Left: " + Mathf.Round(timeLeft);
        if(timeLeft < 0 && Checked == false )  //When time runs out and checked = false...
        {
            PauseGame();
            CheckAnswersPPEScript.CheckingAnswers();  
            Checked = true;  //So that the if condition is not met again.
            CheckButtonPanel.SetActive(false);  //Hide check button.
            NextButtonPanel.SetActive(true);   //Show Next button.
            foreach(GameObject x in LeftRightButtons)  //Make the buttons that allow the user to switch between PPE inactive.
            {
                x.SetActive(false);
            }
        }
    }

    public void PauseGame()  //Pause game and timer. Used when instructions are displayed, the help menu is active, and when the time runs out.
    {
        Time.timeScale = 0;
    }

    public void ResumeGame ()  //REsume game and timer.
    {
        Time.timeScale = 1;
    }
}
