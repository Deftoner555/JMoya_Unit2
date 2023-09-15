using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float TopOfScene = 30f;
    private float BottomOfScene = -8f;

    void Start()
    {
        
    }

    void Update()
    {
        if (transform.position.z > TopOfScene)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < BottomOfScene) 
        { 
            Destroy(gameObject); 
        }
    }
}
