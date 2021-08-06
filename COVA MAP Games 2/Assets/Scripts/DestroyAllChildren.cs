using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        
        ///The above is working. The Children to destroy are in the array.
        
        Debug.Log("Children to Destroy " +ChildrenToDestroy);
        
        
        foreach( var x in ChildrenToDestroy) 
		{
 		 	Debug.Log( x.ToString());
	    }

        ///

        ///Trying to destroy.
        
        foreach(GameObject go in ChildrenToDestroy)
            {
                ///this is working but the orginial objects still stay.
                Destroy(go);
            }
    }
}
