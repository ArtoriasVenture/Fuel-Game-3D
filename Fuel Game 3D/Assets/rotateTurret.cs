using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateTurret : MonoBehaviour
{

void Update(){
    Vector3 mousePosition = Input.mousePosition;
    mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

    Vector3 direction = new Vector3(mousePosition.x - transform.position.x, mousePosition.z - transform.position.z);

    transform.up = direction;
}
}
