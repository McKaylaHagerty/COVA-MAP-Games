using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScenarioInfoPanels : MonoBehaviour
{
    public GameObject AboutText;
    public GameObject AboutTextPanel;
    public Timer TimerScript;

    // Start is called before the first frame update
    void Start()
    {
        AboutText.GetComponent<Text>().text = DontDestroy.InstructionsText;
        TimerScript.PauseGame();
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            AboutTextPanel.SetActive(false);
            TimerScript.ResumeGame();
        }
    }


}
