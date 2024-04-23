using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clampVel : MonoBehaviour
{
float maxSpeed = 1f;
Rigidbody a_Rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        a_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdateUpdate()
    {
        GetComponent<Rigidbody>().velocity = Vector3.ClampMagnitude(GetComponent<Rigidbody>().velocity, maxSpeed);
    }
}
