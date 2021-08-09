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
        Application.Quit();
    }

}
