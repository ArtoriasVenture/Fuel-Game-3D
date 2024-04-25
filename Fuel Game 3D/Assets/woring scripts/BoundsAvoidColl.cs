using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundsAvoidColl : MonoBehaviour
{
    void Start()
    {
        Physics.IgnoreLayerCollision(6, 10 );
        Physics.IgnoreLayerCollision(7, 10 );
        Physics.IgnoreLayerCollision(0, 10 );

    }
}
