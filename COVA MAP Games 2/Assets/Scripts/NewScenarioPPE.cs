using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewScenarioPPE : MonoBehaviour
{
        private int index;

        public void PickNewScenario()
        {
        DontDestroy.ScenarioList.Remove(DontDestroy.ScenarioChoice);  

        if(DontDestroy.ScenarioList.Count > 0)
        {
            index = Random.Range(0, DontDestroy.ScenarioList.Count - 1);
            DontDestroy.ScenarioChoice = DontDestroy.ScenarioList[index];

            Debug.Log(DontDestroy.ScenarioChoice);

            SceneManager.LoadScene("PPE");
        }

        else
        {
            Debug.Log("Game over");
            SceneManager.LoadScene("PPE");
        }

        }

}
