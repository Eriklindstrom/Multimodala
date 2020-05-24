using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickMovement : MonoBehaviour {
	public float rotY = 0.0f;
	public float rotX = 0.0f;
	public float clampAngle = 80.0f;
	private Rigidbody rb;
	public float speed;
	// Use this for initialization
	void Start () {
		rb = GetComponent <Rigidbody> ();
		Vector3 rot = transform.localRotation.eulerAngles;
		rotY = rot.y;
		rotX = rot.x;
	}
	
	// Update is called once per frame
	void Update () {
		float forceX = Input.GetAxis ("LeftJoystickX")*100;
		float forceY = Input.GetAxis ("LeftJoystickY")*100;


	
	
		transform.Translate(0f, 0f,speed*Time.deltaTime);
		transform.Rotate(forceY*Time.deltaTime, forceX*Time.deltaTime, 0f);








		 
	}


}
