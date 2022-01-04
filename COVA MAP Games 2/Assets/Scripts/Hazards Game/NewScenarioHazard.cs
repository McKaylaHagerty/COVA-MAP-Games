using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Randomly chooses another scenario from the scenario list and then loads the PPE scene again. If there are no scenarios left, only the quit button is displayed. 

public class NewScenarioHazard : MonoBehaviour
{

        public GameObject NewScenarioButtonPanel;
        public CSV CSVScript;

    public void Start()
    {

        DontDestroy.CorrectList.Clear();

        DontDestroy.ScenarioList.Remove(DontDestroy.ScenarioChoice);   //Remove the used scenario.
        DontDestroy.InstructionsList.Remove(DontDestroy.InstructionsText);

        if (DontDestroy.ScenarioList.Count == 0)   //If there are no scenarios left, hide the next scenario button.
        {
            NewScenarioButtonPanel.SetActive(false);
        }
    }

    private int index;

    public void PickNewScenario()
    {

        if (DontDestroy.ScenarioList.Count > 0)   //If there are scenarios left, pick a new one and reload the PPE Game scene.
        {
            index = Random.Range(0, DontDestroy.ScenarioList.Count - 1);
            DontDestroy.ScenarioChoice = DontDestroy.ScenarioList[index];
            DontDestroy.InstructionsText = DontDestroy.InstructionsList[index];

            DontDestroy.CorrectHazardsList.Add(CSV.Find_Scenario(DontDestroy.ScenarioChoice).Hazard1);
            DontDestroy.CorrectHazardsList.Add(CSV.Find_Scenario(DontDestroy.ScenarioChoice).Hazard2);
            DontDestroy.CorrectHazardsList.Add(CSV.Find_Scenario(DontDestroy.ScenarioChoice).Hazard3);
            DontDestroy.CorrectHazardsList.Add(CSV.Find_Scenario(DontDestroy.ScenarioChoice).Hazard4);
            DontDestroy.CorrectHazardsList.Add(CSV.Find_Scenario(DontDestroy.ScenarioChoice).Hazard5);
            DontDestroy.CorrectHazardsList.Add(CSV.Find_Scenario(DontDestroy.ScenarioChoice).Hazard6);
            DontDestroy.CorrectHazardsList.Add(CSV.Find_Scenario(DontDestroy.ScenarioChoice).Hazard7);
            DontDestroy.CorrectHazardsList.Add(CSV.Find_Scenario(DontDestroy.ScenarioChoice).Hazard8);
            DontDestroy.CorrectHazardsList.Add(CSV.Find_Scenario(DontDestroy.ScenarioChoice).Hazard9);
            DontDestroy.CorrectHazardsList.Add(CSV.Find_Scenario(DontDestroy.ScenarioChoice).Hazard10);
            DontDestroy.CorrectHazardsList.Add(CSV.Find_Scenario(DontDestroy.ScenarioChoice).Hazard11);
            DontDestroy.CorrectHazardsList.Add(CSV.Find_Scenario(DontDestroy.ScenarioChoice).Hazard12);


            Debug.Log(DontDestroy.ScenarioChoice);

            SceneManager.LoadScene("PPE");
        }

    }

}


