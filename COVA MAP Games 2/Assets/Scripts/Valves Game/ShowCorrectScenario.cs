using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCorrectScenario : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Scenario1Panel;
    public GameObject Scenario2Panel;
    public GameObject Scenario3Panel;

    void Start()
    {
        if(DontDestroy.ScenarioChoice=="1")
        {
            Scenario1Panel.SetActive(true);
            Scenario2Panel.SetActive(false);
            Scenario3Panel.SetActive(false);
        }
        if (DontDestroy.ScenarioChoice == "2")
        {
            Scenario1Panel.SetActive(false);
            Scenario2Panel.SetActive(true);
            Scenario3Panel.SetActive(false);
        }
        if (DontDestroy.ScenarioChoice == "3")
        {
            Scenario1Panel.SetActive(false);
            Scenario2Panel.SetActive(false);
            Scenario3Panel.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
