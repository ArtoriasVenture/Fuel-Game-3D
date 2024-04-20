using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTest : MonoBehaviour
{
    
    private Rigidbody rb;

    public float maxVelocity = 3;

    public float rotationSpeed = 3;

    #region Monobehaviour API
    
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        float zAxis = Input.GetAxis("Horizontal");
        float xAxis = Input.GetAxis("Horizontal");

        ThrustForward(zAxis);
        Rotate(transform, xAxis * -rotationSpeed);
    }

    #endregion

    #region Maneuvering API
   
    private void ClampVelocity()
    {
        float x = Mathf.Clamp(rb.velocity.x, -maxVelocity, maxVelocity);
        float z = Mathf.Clamp(rb.velocity.z, -maxVelocity, maxVelocity);

        rb.velocity = new Vector3(x, z);
    }
    
    private void ThrustForward(float amount)
    {
        Vector3 force = transform.forward * amount;

        rb.AddForce(force);    }

    private void Rotate(Transform t, float amount)
    {
        t.Rotate(0, amount, 0);
    }
    #endregion
}
