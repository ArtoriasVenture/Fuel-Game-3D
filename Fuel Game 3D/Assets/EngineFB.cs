using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineFB : MonoBehaviour
{
    private Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        //float h = Input.GetAxis("Horizontal") * 5;
        float v = Input.GetAxis("Vertical") * 5;

        Vector3 velo = rb.velocity;
        //velo.x = h;
        velo.z = v;
        rb.velocity = velo;
    }
}