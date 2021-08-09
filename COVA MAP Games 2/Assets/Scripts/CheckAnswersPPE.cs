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

    public GameObject Panel;

    //public int NumberCorrect;

    public int NumberTimesChecked = 0;

    //Checks the active images (DressScript.check or the CheckList) against 
    //the correct answers (DontDestroy.CorrectList).

    public void CheckingAnswers()
    {
        DestroyAllChildrenScript.DestroyChildren();
        CheckList.Clear();
        DontDestroy.NumberCorrect = 0;

        NumberTimesChecked = NumberTimesChecked + 1;
        
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
            //var destroyTime = 1;

            if(DontDestroy.CorrectList.Contains(CheckList[i].name))
            {
                Debug.Log("match");
                CorrectIndicator = Instantiate(CorrectIncorrectPrefab, CheckList[i].transform.parent.localPosition, Quaternion.identity);
                CorrectIndicator.GetComponent<CorrectIncorect>().AssignCorrect();
                CorrectIndicator.transform.SetParent(Panel.transform, false);
                DontDestroy.NumberCorrect = DontDestroy.NumberCorrect + 1;
                Debug.Log("Number Correct: " + DontDestroy.NumberCorrect + " Number of Times Checked: " + NumberTimesChecked);
            }
            else
            {
                Debug.Log("not matching");
                IncorrectIndicator = Instantiate(CorrectIncorrectPrefab, CheckList[i].transform.parent.localPosition, Quaternion.identity);
                IncorrectIndicator.GetComponent<CorrectIncorect>().AssignIncorrect();
                IncorrectIndicator.transform.SetParent(Panel.transform, false);
                //ShowAndHide(IncorrectIndicator);
                StartCoroutine(ShowAndHide(IncorrectIndicator));
            }
        }
    }
///not working
    public IEnumerator ShowAndHide(GameObject x)
    {
        yield return new WaitForSeconds(2);
        Destroy(x);
        Debug.Log("got here");
    }
}
    
