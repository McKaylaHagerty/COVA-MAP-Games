using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitApplication : MonoBehaviour
{
    public void Start()
    {
        StartCoroutine(QuitTheApplication());
    }

    public IEnumerator QuitTheApplication()
    {
        yield return new WaitForSeconds(5);
        Debug.Log("Quitting");
        #if (UNITY_EDITOR || DEVELOPMENT_BUILD)
        Debug.Log(this.name+" : "+this.GetType()+" : "+System.Reflection.MethodBase.GetCurrentMethod().Name); 
        #endif
        #if (UNITY_EDITOR)
        UnityEditor.EditorApplication.isPlaying = false;
        #elif (UNITY_STANDALONE) 
        Application.Quit();
        #elif (UNITY_WEBGL)
        Application.OpenURL("quit.html");
        #endif
    }

}
