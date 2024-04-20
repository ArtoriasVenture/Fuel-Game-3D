using UnityEngine;

public class Follow_player : MonoBehaviour {

public float xA = 0;
public float yA= 0;
public float zA = 0;

    public Transform player;

    // Update is called once per frame
    void Update () {
        transform.position = player.transform.position + new Vector3(xA , yA, zA);
    }
}
//https://stackoverflow.com/questions/65816546/unity-camera-follows-player-script