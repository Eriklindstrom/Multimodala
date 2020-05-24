using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective : MonoBehaviour {

	private List<Component> rings = new List<Component>();
	private Component[] bajs;

	public Material activeRing;
	public Material inactiveRing;
	public Material finalRing;

	private int ringPassed = 0;

	private void Start() {

		bajs = GetComponentsInChildren<Ring>();
		//At the start of the level, assign inactive to all rings.
		foreach (Ring r in bajs) {
			r.GetComponent<MeshRenderer>().material = inactiveRing;
			rings.Add(r);
		}

		//OLD: Add to a list for easy handling when we want to know which one is next
		// foreach (Transform t in transform) {
		// 	rings.Add(t);
		// }


		//Activate the first ring
		rings[ringPassed].GetComponent<MeshRenderer>().material = activeRing;
		rings[ringPassed].GetComponent<Ring>().ActivateRing();

	}

	public void NextRing(int latestRing) {

		rings [latestRing].GetComponent<Animator> ().SetTrigger ("collectionTrigger");
	
		//Debug.Log ("Hej " + rings[ringPassed].name);

		//If this is the next to last
		//if (ringPassed == rings.Count -1) {
		//	rings[ringPassed].GetComponent<MeshRenderer>().material = finalRing;
		//}
		//else {
		rings[latestRing].GetComponent<MeshRenderer>().material = activeRing;
		//}
			

		//In both cases, we need to activate the rings.
		rings[latestRing].GetComponent<Ring>().ActivateRing();

	}

	//public void OnTriggerEnter(Collider other) {
	//	latestRing = other.gameObject.name;
	//}

	private void Victory() {
		Debug.Log("DU VANN WOO!");
	}
}
