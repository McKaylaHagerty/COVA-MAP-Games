using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class ButtonControls : MonoBehaviour
{

// -------- Intro Scene ----------- //
    public void SkipIntroButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

// -------- MainMenu Scene ----------- //
    public void PlayGamesButton()
    {
        SceneManager.LoadScene("Levels");
    }
    
    public void QuitButton()
    {
        SceneManager.LoadScene("Quit");
    }

// -------- Levels Scene ----------- //
    public string LevelChoice;

    public void EasyChoiceButton()
    {   
        LevelChoice = "Easy";
        DontDestroy.LevelChoice = LevelChoice;
        SceneManager.LoadScene("Games");
        Debug.Log(DontDestroy.LevelChoice);
    }

    public void MediumChoiceButton()
    {   
        LevelChoice = "Medium";
        DontDestroy.LevelChoice = LevelChoice;
        SceneManager.LoadScene("Games");
        Debug.Log(DontDestroy.LevelChoice);
    }

    public void HardChoiceButton()
    {   
        LevelChoice = "Hard";
        DontDestroy.LevelChoice = LevelChoice;
        SceneManager.LoadScene("Games");
        Debug.Log(DontDestroy.LevelChoice);
    }

    public void LevelsBackButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

// -------- Games Scene ----------- //
    public string GameChoice;

    public void PPEGameChoiceButton()
    {   
        GameChoice = "PPE";
        DontDestroy.GameChoice = GameChoice;
        SceneManager.LoadScene("About");
        Debug.Log(DontDestroy.GameChoice);
    }

    public void HazardsGameChoiceButton()
    {   
        GameChoice = "Hazards";
        DontDestroy.GameChoice = GameChoice;
        SceneManager.LoadScene("About");
        Debug.Log(DontDestroy.GameChoice);
    }

    public void ValvesGameChoiceButton()
    {   
        GameChoice = "Valves";
        DontDestroy.GameChoice = GameChoice;
        SceneManager.LoadScene("About");
        Debug.Log(DontDestroy.GameChoice);
    }

    public void GamesBackButton()
    {
        SceneManager.LoadScene("Levels");
    }

// -------- About Scene ----------- //
    public void AboutBackButton()
    {
        SceneManager.LoadScene("Games");
    }

    public void AboutNextButton()
    {
        SceneManager.LoadScene("PPE");
        Debug.Log("PPE Loaded");
    }
}
