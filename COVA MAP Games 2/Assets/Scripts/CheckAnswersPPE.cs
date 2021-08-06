using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CheckAnswersPPE: MonoBehaviour
{
    public List<GameObject> CheckList = new List<GameObject>();
    private int NumObjectsCheck;
    public Dress DressScript;

    public DestroyAllChildren DestroyAllChildrenScript;

     public GameObject CorrectIncorrectPrefab;
    // public GameObject IncorrectPrefab;

     public GameObject Panel;

     //public GameObject newParent;


    public void CheckingAnswers()
    {
        
        DestroyAllChildrenScript.DestroyChildren();
        CheckList.Clear();
        
        for(int i = 0; i < DressScript.NumObjects; i++)  
        {
            if(DressScript.check[i].activeInHierarchy == true)
            {
                CheckList.Add(DressScript.check[i]);
            }
        }
        
        
        for(int i = 0 ; i < CheckList.Count ; i++)
        {
            GameObject CorrectIndicator;
            GameObject IncorrectIndicator;

            if(DontDestroy.CorrectList.Contains(CheckList[i].name))
            {
                Debug.Log("match");
                CorrectIndicator = Instantiate(CorrectIncorrectPrefab, CheckList[i].transform.parent.localPosition, Quaternion.identity);
                CorrectIndicator.GetComponent<CorrectIncorect>().AssignCorrect();
                CorrectIndicator.transform.SetParent(Panel.transform, false);
            }
            else
            {
                Debug.Log("not matching");
                IncorrectIndicator = Instantiate(CorrectIncorrectPrefab, CheckList[i].transform.parent.localPosition, Quaternion.identity);
                IncorrectIndicator.GetComponent<CorrectIncorect>().AssignIncorrect();
                IncorrectIndicator.transform.SetParent(Panel.transform, false);
            }
        }
    }

    

}
    
