using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckButton : MonoBehaviour
{
    public GameObject NextButtonPanel;

    // Start is called before the first frame update
    public void CheckDirections()
    {
        //SceneManager.LoadScene("ScoreboardValves");
        if (CheckFlipDirections())
        {
            print("You are the winner");
        }
        else
        {
            print("You are the loser");
        }
        NextButtonPanel.SetActive(true);
    }

    private bool CheckFlipDirections()
    {
        FlipDirection[] flipDirections = FindObjectsOfType<FlipDirection>();
        if (flipDirections.Length == 0) return true;

        for (int i = 0; i < flipDirections.Length; i++)
        {
            if (flipDirections[i].flipindex != flipDirections[i].correctFlipIndex)
            {
                return false;
            }
        }

        return true;
    }
}
