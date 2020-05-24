using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate( 0, 0, 2*Time.deltaTime );    // speed; see below
    if (transform.localPosition.z >= 10)              // at position 10...
        transform.rotation = Quaternion.Euler(0,180,0);//face backward
    if (transform.localPosition.z <= 0)               // at position 0....
        transform.rotation = Quaternion.Euler(0,0,0);   // face forward
	}
}
