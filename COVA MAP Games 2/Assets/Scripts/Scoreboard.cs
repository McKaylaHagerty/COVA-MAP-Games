using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour
{

    public Text ScoreText;
    public Text CongratsText;
    public Text FailText;

    void Start()
    {
        CongratsText.gameObject.SetActive(false);
        FailText.gameObject.SetActive(false);

        ScoreText.text = "Final Score: " + DontDestroy.Score;

        if(DontDestroy.NumberCorrect == 9)   //If all 9 are correct, show congrats text.
        {
            CongratsText.gameObject.SetActive(true);
        }
        else if(DontDestroy.NumberCorrect < 9)  //If any are incorrect, show fail text.
        {
            FailText.gameObject.SetActive(true);
        }
    }
}
