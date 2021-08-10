using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Randomly chooses another scenario from the scenario list and then loads the 
//PPE scene again. If there are no scenarios left, 

public class NewScenarioPPE : MonoBehaviour
{
        public GameObject NewScenarioButtonPanel;

        public void Start()
        {
            DontDestroy.ScenarioList.Remove(DontDestroy.ScenarioChoice);

            if(DontDestroy.ScenarioList.Count == 0)
            {
                NewScenarioButtonPanel.SetActive(false);
            }
        }
        
        private int index;

        public void PickNewScenario()
        {  

        if(DontDestroy.ScenarioList.Count > 0)
        {
            index = Random.Range(0, DontDestroy.ScenarioList.Count - 1);
            DontDestroy.ScenarioChoice = DontDestroy.ScenarioList[index];

            Debug.Log(DontDestroy.ScenarioChoice);

            SceneManager.LoadScene("PPE");
        }

        }

}
