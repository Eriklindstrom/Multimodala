using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour {

	private int score;
	private Objective objectiveScript;
	private bool ringActive = false;

	public int latestRing;

	// Use this for initialization
	void Start () {
		objectiveScript = FindObjectOfType<Objective>();
	}

	public void ActivateRing() {
		ringActive = true;
	}

	private void OnTriggerEnter(Collider other) {
		//If ring is active, tell the objectivescript that it has been passed through
		latestRing = Convert.ToInt32(gameObject.name);
		objectiveScript.NextRing(latestRing);


	}

	// Update is called once per frame
	void Update () {

	}
}
