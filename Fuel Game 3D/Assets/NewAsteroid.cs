using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewAsteroid : MonoBehaviour
{
    public float a = 10;
    public float b = 5;
    public int size = 3;
    
    public float armedTime = 120;

    void Awake()
    {
        Destroy(gameObject, armedTime);
    }

    // Update is called once per frame
   void Update()
    {
    transform.localScale = 0.5f * size * Vector3.one;

    Rigidbody rb = GetComponent<Rigidbody>();
    Vector3 direction = new Vector3(a,0,b).normalized;
    float spawnSpeed = Random.Range(4f - size, 5f - size);
    rb.AddForce(direction * spawnSpeed, ForceMode.Impulse);
    }

    void destroyed(Collision collision)
    {
        Destroy(gameObject);   
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<Health>(out var health))
        {
            health.Damage(amount:100);
            //Destroy(gameObject);
        }
    }
    
}
