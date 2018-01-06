using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script enables the camera to follow the player

public class CamControl : MonoBehaviour
{
    public GameObject Player;
    private Vector3 offset;

	// Use this for initialization
	void Start ()
    {
        offset = transform.position - Player.transform.position;
	}
	
	// runs after all items have been processed in Update
	void LateUpdate ()
    {
        transform.position = Player.transform.position + offset;
	}
}
