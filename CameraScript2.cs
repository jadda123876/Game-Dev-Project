using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript2 : MonoBehaviour {

    private GameObject player;
    // private Vector3 offsetPosition = new Vector3(0.0f,5.0f,-12.0f);
    private Vector3 offsetPosition;
    private readonly Space offsetPositionSpace = Space.Self;
    private readonly bool lookAt = true;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
        offsetPosition = transform.position - player.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void LateUpdate()
    {
        // compute position
        if (offsetPositionSpace == Space.Self)
        {
            transform.position = player.transform.TransformPoint(offsetPosition);
        }
        else
        {
            transform.position = player.transform.position + offsetPosition;
        }

        // compute rotation
        if (lookAt)
        {
            transform.LookAt(player.transform);
        }
        else
        {
            transform.rotation = player.transform.rotation;
        }
    }
}
