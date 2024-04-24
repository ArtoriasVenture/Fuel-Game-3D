using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// script found at:
//https://www.youtube.com/watch?v=EwiUomzehKU
public class shootTurret : MonoBehaviour
{
    public KeyCode fireTurret;
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(fireTurret)){
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
        }
    }
}
