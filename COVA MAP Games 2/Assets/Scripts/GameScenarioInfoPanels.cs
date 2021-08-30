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
    public GameObject ScenarioText;
    public GameObject ScenarioReminderText;

    void Start()
    {
        AboutText.GetComponent<Text>().text = DontDestroy.InstructionsText;  //Pull scenario instructions text that was saved to the DoNotDestroy script.
        TimerScript.PauseGame();  //Game starts paused until the scenario instructions are read and the user proceeds to the game.
        DontDestroy.ScenarioCounter = DontDestroy.ScenarioCounter + 1;
        ScenarioReminderText.GetComponent<Text>().text = "Dressing for "+DontDestroy.ScenarioReminderText+".";

        if (DontDestroy.GameChoice == "PPE")
        {
            ScenarioText.GetComponent<Text>().text = "Scenario: " + DontDestroy.ScenarioCounter + "/5";
        }

        if (DontDestroy.GameChoice == "Valves")
        {
            ScenarioText.GetComponent<Text>().text = "Scenario: " + DontDestroy.ScenarioCounter + "/3";
        }
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
