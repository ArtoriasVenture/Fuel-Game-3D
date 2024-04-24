using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimBounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Physics.IgnoreLayerCollision(6,8);
        Physics.IgnoreLayerCollision(7,8);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
