using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{

    public Transform player; 
    public float x,y,z;

    // Start is called before the first frame update
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            player.position = new Vector3(x,y,z);
        }
    }
}
