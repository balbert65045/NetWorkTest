using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class player : NetworkBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!isLocalPlayer)
        {
            return;
        }

        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.left * h + Vector3.forward * v);


	}
}
