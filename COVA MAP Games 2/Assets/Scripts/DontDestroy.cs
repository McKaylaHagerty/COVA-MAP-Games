using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public static string LevelChoice;
    public static string GameChoice;
    public static List<string> CorrectList= new List<string>();
    public static string ScenarioChoice;
    public static string InstructionsText;
    public static string AboutGameText;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
