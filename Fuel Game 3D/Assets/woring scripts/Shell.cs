using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// script found at:
//https://www.youtube.com/watch?v=EwiUomzehKU
public class Shell : MonoBehaviour
{
    public float armedTime = 4;

    void Awake()
    {
        Destroy(gameObject, armedTime);
    }

    
    void OnCollisionEnter(Collision collision)
    {
        
    }
}
