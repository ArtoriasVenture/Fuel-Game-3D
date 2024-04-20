using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thruster : MonoBehaviour
{
    public KeyCode MoveForward;

    Rigidbody m_Rigidbody;
   
    public float m_Thrust = 20f;
    public float r_Thrust = 5f;

    public GameObject ThrustLight;

    void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(MoveForward))
        {
            //Apply a force to this Rigidbody in direction of this GameObjects up axis
            m_Rigidbody.AddForce(transform.up * m_Thrust);
            ThrustLight.SetActive( true );
        }
        else{          
            ThrustLight.SetActive( false );
            //if (m_Rigidbody.AddForce != 0)
                //m_Rigidbody.AddForce(-transform.up * r_Thrust);
        }
    }

 
}
