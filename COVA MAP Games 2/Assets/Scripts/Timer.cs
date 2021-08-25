using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Timer : MonoBehaviour

{
    public Text text;   //Timer text.
    public float time = 0.0f;
    public float timeLeft = 0.0f;

    //Referencing other scripts.
    public CheckAnswersPPE CheckAnswersPPEScript;  
    public ScoringPPE ScoringPPEScript;

    public GameObject NextButtonPanel; 
    public GameObject CheckButtonPanel;
    public GameObject[] LeftRightButtons;  //Array of the buttons that allow the user to switch between PPE.

    public Image hard;
    public Image medium;
    public Image easy;

    public void Start()
    {
        time = 20.0f;

        if (DontDestroy.GameChoice == "PPE")
        {
            CheckButtonPanel.SetActive(true);   //Check button is active to start. Will disappear when time runs out.
        }

        if (DontDestroy.GameChoice == "Valves")
        {
            CheckButtonPanel.SetActive(false);   //Check button is active to start. Will disappear when time runs out.
        }

        NextButtonPanel.SetActive(false);    //Next button is inactive to start. Will appear when time runs out.

        if (DontDestroy.GameChoice == "PPE")
        {
            foreach (GameObject x in LeftRightButtons)  //All the buttons that allow the user to switch between PPE are active to start. Will disappear when time runs out.
            {
                x.SetActive(true);
            }
        }


        //Choose time allowed based on level choice.

        if(DontDestroy.LevelChoice == "Easy")
        {
            timeLeft = 60.0f;
        }

        else if(DontDestroy.LevelChoice == "Medium")
        {
            timeLeft = 40.0f;
            easy.enabled = false;
        }

        else if(DontDestroy.LevelChoice == "Hard")
        {
            timeLeft = 20.0f;  //To be changed back to 20.0
            easy.enabled = false;
            medium.enabled = false;
        }       
    }

    bool Checked = false;  //Bool need to use as a condition to stop the update method.
    public void Update()  //Timer counts down in seconds.
    {
        //Debug.Log($"My F**** Time Scale is: ${Time.timeScale}");
        timeLeft -= Time.deltaTime;
        text.text = "" + Mathf.Round(timeLeft);

        if(timeLeft<=20.0f)
        {
            hard.fillAmount -= 1.0f / time * Time.deltaTime;
        }

        if (timeLeft <= 40.0f)
        {
            medium.fillAmount -= 1.0f / time * Time.deltaTime;
        }

        if (timeLeft <= 60.0f)
        {
            easy.fillAmount -= 1.0f / time * Time.deltaTime;
        }

        if (timeLeft < 0 && Checked == false )  //When time runs out and checked = false...
        {
            PauseGame();
            if (DontDestroy.GameChoice == "PPE")
            {
                CheckAnswersPPEScript.CheckingAnswers();
                Checked = true;  //So that the if condition is not met again.
                CheckButtonPanel.SetActive(false);  //Hide check button.
                NextButtonPanel.SetActive(true);   //Show Next button.
                foreach (GameObject x in LeftRightButtons)  //Make the buttons that allow the user to switch between PPE inactive.
                {
                    x.SetActive(false);
                }
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
