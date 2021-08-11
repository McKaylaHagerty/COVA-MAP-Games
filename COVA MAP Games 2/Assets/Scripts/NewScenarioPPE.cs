using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Randomly chooses another scenario from the scenario list and then loads the PPE scene again. If there are no scenarios left, only the quit button is displayed. 

public class NewScenarioPPE : MonoBehaviour
{
        public GameObject NewScenarioButtonPanel;  

        public void Start()
        {
            DontDestroy.ScenarioList.Remove(DontDestroy.ScenarioChoice);   //Remove the used scenario.

            if(DontDestroy.ScenarioList.Count == 0)   //If there are no scenarios left, hide the next scenario button.
            {
                NewScenarioButtonPanel.SetActive(false);
            }
        }
        
        private int index;

        public void PickNewScenario()
        {  

        if(DontDestroy.ScenarioList.Count > 0)   //If there are scenarios left, pick a new one and reload the PPE Game scene.
        {
            index = Random.Range(0, DontDestroy.ScenarioList.Count - 1);
            DontDestroy.ScenarioChoice = DontDestroy.ScenarioList[index];

            Debug.Log(DontDestroy.ScenarioChoice);

            SceneManager.LoadScene("PPE");
        }

        }

}
