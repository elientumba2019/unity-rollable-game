using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;

	// Use this for initialization
	void Start () {

        //the current position of the camera - positionof the player
        offset = transform.position - player.transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
	}



    void LateUpdate()
    {
        //as the player object moves , the camera follows
        transform.position = player.transform.position + offset;
    }
}
