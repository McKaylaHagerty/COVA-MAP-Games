using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameScenarioInfoPanels : MonoBehaviour
{
    public GameObject AboutText;  //About the game text.
    public GameObject AboutTextPanel;   //About the game panel (can be hidden).
    public Timer TimerScript;  //Referencing timer script.

    void Start()
    {
        AboutText.GetComponent<Text>().text = DontDestroy.InstructionsText;  //Pull scenario instructions text that was saved to the DoNotDestroy script.
        TimerScript.PauseGame();  //Game starts paused until the scenario instructions are read and the user proceeds to the game.
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0) && AboutTextPanel.activeSelf==true)
        {
            AboutTextPanel.SetActive(false);  //Set the panel with the scenario text inactive.
            TimerScript.ResumeGame();   //Game starts paused until the scenario instructions are read and the user proceeds to the game.
        }
    }


}
