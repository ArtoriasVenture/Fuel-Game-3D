using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// script found at:
//https://www.youtube.com/watch?v=EwiUomzehKU
public class Bullet : MonoBehaviour
{
    public float armedTime = 3;

    void Awake()
    {
        Destroy(gameObject, armedTime);
    }

    
    void OnCollisionEnter(Collision collision)
    {
        
    }
}
