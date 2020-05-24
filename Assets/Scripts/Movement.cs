using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public float moveSpeedRotation;
	public float moveSpeed;
	public Rigidbody rb;


	// Use this for initialization
	void Start () {
		moveSpeedRotation = (40f);
		moveSpeed = (25f);
		rb = GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {
		moveSpeedRotation = (40f);
		moveSpeed = (25f);
		transform.Translate(moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime,moveSpeedRotation*Input.GetAxis("Vertical")*Time.deltaTime,moveSpeedRotation*Time.deltaTime);
		//Debug.Log (moveSpeed);
	
		rb.AddForce (0f,0f, moveSpeed * Time.deltaTime);

		//rb.angularVelocity = new Vector3(0,0,0);
		//Debug.Log ("Velo: " + rb.angularVelocity);
		//Debug.Log ("tet");

		//Vector3 Moving = new Vector3(moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime, moveSpeed*Input.GetAxis("Vertical")*Time.deltaTime,moveSpeed*Time.deltaTime);
		//var inputVector : Vector3 = Vector3(moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime, moveSpeed*Input.GetAxis("Vertical")*Time.deltaTime,moveSpeed*Time.deltaTime);
		//GetComponent(RigidBody).AddForce(Moving * 100);
	}


	}
