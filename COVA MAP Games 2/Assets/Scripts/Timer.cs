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
    public CheckAnswersPPE CheckAnswersPPEScript;
    public ScoringPPE ScoringPPEScript;

    public void Start()
    {
        CheckButtonPanel.SetActive(true);
        NextButtonPanel.SetActive(false);
        foreach(GameObject x in LeftRightButtons)
        {
            x.SetActive(true);
        }

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
            timeLeft = 5.0f;
        }       
    }

    bool Checked = false;
    public GameObject NextButtonPanel;
    public GameObject CheckButtonPanel;
    public GameObject[] LeftRightButtons;
    public void Update()
    {
        timeLeft -= Time.deltaTime;
        text.text = "Time Left: " + Mathf.Round(timeLeft);
        if(timeLeft < 0 && Checked == false )
        {
            PauseGame();
            CheckAnswersPPEScript.CheckingAnswers();
            Checked = true;
            CheckButtonPanel.SetActive(false);
            NextButtonPanel.SetActive(true);
            foreach(GameObject x in LeftRightButtons)
            {
                x.SetActive(false);
            }
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
