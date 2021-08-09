using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Destroy the children of the panel which only contains the incorrect/correct
//instantiated prefabs.

public class DestroyAllChildren : MonoBehaviour
{
    public GameObject[] ChildrenToDestroy;
    
    public void DestroyChildren()
    {
        ChildrenToDestroy = new GameObject[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
            {
                ChildrenToDestroy[i] = transform.GetChild(i).gameObject;
            }
        
        foreach(GameObject go in ChildrenToDestroy)
            {
                Destroy(go);
            }
    }
}
