using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject spawnee;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject",spawnTime,spawnDelay);
    }

    // Update is called once per frame
    public void SpawnObject(){
        Instantiate(spawnee, transform.position, transform.rotation);
        //spawnee.GetComponent<Rigidbody>().AddForce (transform.up * 10);
        if(stopSpawning){
            CancelInvoke("SpawnObject");
        }
    }
    
}
