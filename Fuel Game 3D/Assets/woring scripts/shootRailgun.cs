using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// script found at:
//https://www.youtube.com/watch?v=EwiUomzehKU
public class shootRailgun : MonoBehaviour
{
    public KeyCode fireRailgun;
    public Transform shellSpawnPoint;
    public GameObject shellPrefab;
    public float shellSpeed = 10;
    public GameObject RailgunLight;
    public float m_Thrust = 10f;
    Rigidbody m_Rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        //RailgunLight.SetActive( false ); 
        m_Rigidbody = GetComponent<Rigidbody>();
    }
    
    void Awake()
    {
        RailgunLight.SetActive( false ); 
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(fireRailgun)){
            Invoke("fireShell",.2f);
            Invoke("SetFalse",.5f);
        }

 
    }
    void fireShell(){
        var shell = Instantiate(shellPrefab, shellSpawnPoint.position, shellSpawnPoint.rotation);
            shell.GetComponent<Rigidbody>().velocity = shellSpawnPoint.forward * shellSpeed;
            RailgunLight.SetActive( true );
            m_Rigidbody.AddForce(-transform.up * m_Thrust);
    }
    void SetFalse()
    {
    RailgunLight.SetActive( false ); 
    }

}
