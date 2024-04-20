using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MapBorder : MonoBehaviour
{
    public static MapBorder instance;
    
    public bool trig = false;

    public float timer = 15f;

    public Text timerText;

    public GameObject uiArt;

    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        if(trig){
            timer -= Time.deltaTime;
           // timerText = timer.ToString ("F1");

            if (timer <= 0 ){
                print ("Abandoned Mission Area");
                trig = false;
            }
        }
    }

    void OnTriggerEnter()
    {
        //if (other.GameObject.tag == "newPlayer"){
            trig = false;
            uiArt.SetActive (false);
            timer = 15f;
        //}
    }

     void OnTriggerExit()
    {
        //if (other.GameObject.tag == "newPlayer"){
            uiArt.SetActive (true);
            trig = true;
        //}
    }

}
