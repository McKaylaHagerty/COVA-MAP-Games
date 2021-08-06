using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpPanelScript : MonoBehaviour
{
    public GameObject HelpPanel;
    public Timer TimerScript;

    void Start()
    {
        HelpPanel.SetActive(false);
    }

    public void OpenHelpPanel()
    {
        HelpPanel.SetActive(true);
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            HelpPanel.SetActive(false);
            TimerScript.ResumeGame();
        }
    }
}
