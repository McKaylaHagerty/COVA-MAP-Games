using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoringValves : MonoBehaviour
{
    public Timer TimerScript;

    public Text text;  //Score text.

    public GameObject CheckButtonPanel;
    public GameObject AboutValvePanel; 

    public void GetScore() 
    {
        if (DontDestroy.LevelChoice == "Easy")
        {
            DontDestroy.Score = DontDestroy.NumberCorrect * 45/(System.Convert.ToInt32(DontDestroy.NumberOfValves)) + (DontDestroy.NumberTimesChecked) * (-6);
            Debug.Log(DontDestroy.Score);
            text.text = "Score: " + DontDestroy.Score;
            if (DontDestroy.NumberCorrect == System.Convert.ToInt32(DontDestroy.NumberOfValves) || DontDestroy.timeLeft < 0)   
            {
                AboutValvePanel.SetActive(false);
                CheckButtonPanel.SetActive(true);
                TimerScript.PauseGame();
            }
        }
        else if (DontDestroy.LevelChoice == "Medium")
        {
            DontDestroy.Score = DontDestroy.NumberCorrect * 45 / (System.Convert.ToInt32(DontDestroy.NumberOfValves)) + (DontDestroy.NumberTimesChecked) * (-6);
            Debug.Log(DontDestroy.Score);
            text.text = "Score: " + DontDestroy.Score;
            if (DontDestroy.NumberCorrect == System.Convert.ToInt32(DontDestroy.NumberOfValves) || DontDestroy.timeLeft < 0)   
            {
                AboutValvePanel.SetActive(false);
                CheckButtonPanel.SetActive(true);
                TimerScript.PauseGame();
            }
        }
        else if (DontDestroy.LevelChoice == "Hard")
        {
            DontDestroy.Score = DontDestroy.NumberCorrect * 45 / (System.Convert.ToInt32(DontDestroy.NumberOfValves)) + (DontDestroy.NumberTimesChecked) * (-6);
            Debug.Log(DontDestroy.Score);
            text.text = "Score: " + DontDestroy.Score;
            if (DontDestroy.NumberCorrect == System.Convert.ToInt32(DontDestroy.NumberOfValves) || DontDestroy.timeLeft < 0)   
            {
                AboutValvePanel.SetActive(false);
                CheckButtonPanel.SetActive(true);
                TimerScript.PauseGame();
            }
        }
    }
}
