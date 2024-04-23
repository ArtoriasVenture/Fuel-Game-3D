using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class rotateTurret : MonoBehaviour
{
    
    public GameObject player;
    void Update()
{
    Vector3 mouse = Input.mousePosition;
    Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(new Vector3( mouse.x, mouse.y, player.transform.position.y));
    Vector3 forward = mouseWorld - player.transform.position;
    Quaternion Rotation = Quaternion.LookRotation(forward, Vector3.up);
    //LimitY = new Vector3(0, Rotation.y, 0);
    transform.rotation = new Vector3(0, Rotation.y, 0);
}

}
*/