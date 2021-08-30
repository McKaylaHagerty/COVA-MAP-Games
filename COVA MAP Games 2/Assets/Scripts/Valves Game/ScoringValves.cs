using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoringValves : MonoBehaviour
{
    public Timer TimerScript;

    public Text text;  //Score text.

    public void GetScore() 
    {
        if (DontDestroy.LevelChoice == "Easy")
        {
            DontDestroy.Score = 35 + DontDestroy.NumberCorrect * 9 + (DontDestroy.NumberTimesChecked) * (-4);
            Debug.Log(DontDestroy.Score);
            text.text = "Score: " + DontDestroy.Score;
            if (DontDestroy.NumberCorrect == 5 || DontDestroy.timeLeft < 0)   
            {
                SceneManager.LoadScene("ScoreboardValves");
            }
        }
        else if (DontDestroy.LevelChoice == "Medium")
        {
            DontDestroy.Score = 45 + DontDestroy.NumberCorrect * 9 + (DontDestroy.NumberTimesChecked) * (-4);
            Debug.Log(DontDestroy.Score);
            text.text = "Score: " + DontDestroy.Score;
            if (DontDestroy.NumberCorrect == 5 || DontDestroy.timeLeft < 0)   
            {
                SceneManager.LoadScene("ScoreboardValves");
            }
        }
        else if (DontDestroy.LevelChoice == "Hard")
        {
            DontDestroy.Score = 55 + DontDestroy.NumberCorrect * 9 + (DontDestroy.NumberTimesChecked) * (-4);
            Debug.Log(DontDestroy.Score);
            text.text = "Score: " + DontDestroy.Score;
            if (DontDestroy.NumberCorrect == 5 || DontDestroy.timeLeft < 0)   
            {
                SceneManager.LoadScene("ScoreboardValves");
            }
        }
    }
}
