using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetRotateItself : MonoBehaviour {
	public float RotateX;
	public float RotateY;
	public float RotateZ;

	// Use this for initialization
	void Start () {
		//RotateY = 1;
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(RotateX,RotateY,RotateZ);
	}
}
