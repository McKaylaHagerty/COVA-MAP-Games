using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoringPPE : MonoBehaviour
{
    public CheckAnswersPPE CheckAnswersPPEScript;

    public Timer TimerScript;

    public Text text;

    public void GetScore()
    {
        if(DontDestroy.LevelChoice == "Easy")
        {
            DontDestroy.Score = 35 + CheckAnswersPPEScript.NumberCorrect * 5 + (CheckAnswersPPEScript.NumberTimesChecked - 1) * (-3);
            Debug.Log(DontDestroy.Score);
            text.text = "Score: " + DontDestroy.Score;
            if(CheckAnswersPPEScript.NumberCorrect == 9 || TimerScript.timeLeft < 0)
            {
                SceneManager.LoadScene("Scoreboard");
            }
        }
        else if(DontDestroy.LevelChoice == "Medium")
        {
            DontDestroy.Score = 45 + CheckAnswersPPEScript.NumberCorrect * 5 + (CheckAnswersPPEScript.NumberTimesChecked - 1) * (-3);
            Debug.Log(DontDestroy.Score);
            text.text = "Score: " + DontDestroy.Score;
            if(CheckAnswersPPEScript.NumberCorrect == 9 || TimerScript.timeLeft < 0)
            {
                SceneManager.LoadScene("Scoreboard");
            }
        }    
        else if(DontDestroy.LevelChoice == "Hard")
        {
            DontDestroy.Score = 55 + CheckAnswersPPEScript.NumberCorrect * 5 + (CheckAnswersPPEScript.NumberTimesChecked - 1) * (-3);
            Debug.Log(DontDestroy.Score);
            text.text = "Score: " + DontDestroy.Score;
            if(CheckAnswersPPEScript.NumberCorrect == 9 || TimerScript.timeLeft < 0)
            {
                SceneManager.LoadScene("Scoreboard");
            }
        }    
    }
}
