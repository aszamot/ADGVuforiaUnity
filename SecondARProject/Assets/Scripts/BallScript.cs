using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

    public GameObject Plane;
    public GameObject SpawnPoint;
	
	// Update is called once per frame
	void FixedUpdate () {
		if( transform.position.y < Plane.transform.position.y - 100)
        {
            transform.position = SpawnPoint.transform.position;
        }
	}
}
