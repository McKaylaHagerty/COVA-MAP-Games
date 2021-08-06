using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dress : MonoBehaviour
{
    public GameObject[] dress;
    public GameObject[] check;
    public int NumObjects;

    public void Start()
    {
        NumObjects = dress.Length;

        for(int i = 0; i < NumObjects; i++)
            if (check[i].activeInHierarchy == true)
                dress[i].SetActive(true);
            else if (check[i].activeInHierarchy == false)
                dress[i].SetActive(false);
    }

    public void DetectPPE()
    {
        for(int i = 0; i < NumObjects; i++)
            if (check[i].activeInHierarchy == true)
                dress[i].SetActive(true);
            else if (check[i].activeInHierarchy == false)
                dress[i].SetActive(false);
    }
}
