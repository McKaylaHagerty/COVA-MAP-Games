using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoringPPE : MonoBehaviour
{
    public CheckAnswersPPE CheckAnswersPPEScript;  //Referencing other scripts.
    public Timer TimerScript; 

    public Text text;  //Score text.

    public void GetScore()  //5 points for each correct out of the 9, 55 points for hard, 45 points for medium, 35 points for easy level, -3 points for each check after the first check
    {
        if(DontDestroy.LevelChoice == "Easy")
        {
            DontDestroy.Score = 35 + DontDestroy.NumberCorrect * 5 + (CheckAnswersPPEScript.NumberTimesChecked - 1) * (-3);
            Debug.Log(DontDestroy.Score);
            text.text = "Score: " + DontDestroy.Score;
            if(DontDestroy.NumberCorrect == 9 || TimerScript.timeLeft < 0)   //If all 9 are correct, then go directly to the Scoreboard.
            {
                SceneManager.LoadScene("Scoreboard");
            }
        }
        else if(DontDestroy.LevelChoice == "Medium")
        {
            DontDestroy.Score = 45 + DontDestroy.NumberCorrect * 5 + (CheckAnswersPPEScript.NumberTimesChecked - 1) * (-3);
            Debug.Log(DontDestroy.Score);
            text.text = "Score: " + DontDestroy.Score;
            if(DontDestroy.NumberCorrect == 9 || TimerScript.timeLeft < 0)   //If all 9 are correct, then go directly to the Scoreboard.
            {
                SceneManager.LoadScene("Scoreboard");
            }
        }    
        else if(DontDestroy.LevelChoice == "Hard")
        {
            DontDestroy.Score = 55 + DontDestroy.NumberCorrect * 5 + (CheckAnswersPPEScript.NumberTimesChecked - 1) * (-3);
            Debug.Log(DontDestroy.Score);
            text.text = "Score: " + DontDestroy.Score;
            if(DontDestroy.NumberCorrect == 9 || TimerScript.timeLeft < 0)   //If all 9 are correct, then go directly to the Scoreboard.
            {
                SceneManager.LoadScene("Scoreboard");
            }
        }    
    }
}
