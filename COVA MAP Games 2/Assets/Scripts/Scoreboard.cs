using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour
{

    public Text ScoreText;
    public Text CongratsText;
    public Text FailText;
    public float TimeBonus = 0.0f;
    public Text TimeBonusText;
    public float TotalScoreWithTimeBonus = 0.0f;
    public GameObject TimeBonusGameObject;

    void Start()
    {
        CongratsText.gameObject.SetActive(false);
        FailText.gameObject.SetActive(false);
        TimeBonusGameObject.gameObject.SetActive(false);

        Time.timeScale = 1;

        if (DontDestroy.GameChoice == "PPE")
        {
            print(DontDestroy.timeLeft);

            if (DontDestroy.LevelChoice == "Hard" && DontDestroy.NumberCorrect == 9)
            {
                TimeBonus = 55.0f;

                ScoreText.text = "Your Score: " + DontDestroy.Score;
                StartCoroutine(GetScoreWithBonus());

            }

            if (DontDestroy.LevelChoice == "Medium" && DontDestroy.NumberCorrect == 9 && DontDestroy.timeLeft >= 20.0)
            {
                TimeBonus = 55.0f;
                ScoreText.text = "Your Score: " + DontDestroy.Score;
                StartCoroutine(GetScoreWithBonus());
            }

            if (DontDestroy.LevelChoice == "Medium" && DontDestroy.NumberCorrect == 9 && DontDestroy.timeLeft < 20.0)
            {
                TimeBonus = 45.0f;
                ScoreText.text = "Your Score: " + DontDestroy.Score;
                StartCoroutine(GetScoreWithBonus());
            }

            if (DontDestroy.LevelChoice == "Easy" && DontDestroy.NumberCorrect == 9 && DontDestroy.timeLeft >= 40.0)
            {
                TimeBonus = 55.0f;
                ScoreText.text = "Your Score: " + DontDestroy.Score;
                StartCoroutine(GetScoreWithBonus());
            }

            if (DontDestroy.LevelChoice == "Easy" && DontDestroy.NumberCorrect == 9 && DontDestroy.timeLeft < 40.0 && DontDestroy.timeLeft >= 20.0)
            {
                TimeBonus = 45.0f;
                ScoreText.text = "Your Score: " + DontDestroy.Score;
                StartCoroutine(GetScoreWithBonus());
            }

            if (DontDestroy.LevelChoice == "Easy" && DontDestroy.NumberCorrect == 9 && DontDestroy.timeLeft < 20.0)
            {
                TimeBonus = 35.0f;
                ScoreText.text = "Your Score: " + DontDestroy.Score;
                StartCoroutine(GetScoreWithBonus());
            }


            if (DontDestroy.NumberCorrect == 9)   //If all 9 are correct, show congrats text.
            {
                CongratsText.gameObject.SetActive(true);
            }

            if (DontDestroy.NumberCorrect < 9)  //If any are incorrect, show fail text.
            {
                FailText.gameObject.SetActive(true);
                ScoreText.text = "Your Score: " + DontDestroy.Score;
            }
        }
        if (DontDestroy.GameChoice == "Valves")
        {
            ScoreText.text = "Your Score: " + DontDestroy.Score;
        }
    }

    public IEnumerator GetScoreWithBonus()
    {
        print("start delay");
        yield return new WaitForSeconds(1);
        TimeBonusText.GetComponent<Text>().text = "+" + TimeBonus.ToString();
        TotalScoreWithTimeBonus = DontDestroy.Score + TimeBonus;
        TimeBonusGameObject.gameObject.SetActive(true);
        yield return new WaitForSeconds(2);
        TimeBonusGameObject.gameObject.SetActive(false);
        ScoreText.GetComponent<Text>().text = "Your Score: " + TotalScoreWithTimeBonus;
        print("end delay");
    }
}
