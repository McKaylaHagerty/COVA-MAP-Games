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

        ScoreText.text = "Score: " + DontDestroy.Score;

        if(DontDestroy.NumberCorrect == 9)
        {
            CongratsText.gameObject.SetActive(true);
        }
        else if(DontDestroy.NumberCorrect < 9)
        {
            FailText.gameObject.SetActive(true);
        }
    }
}
