using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerper : MonoBehaviour {

	public Transform startPos, endPos;
	public bool repeatable = false;
	public float speed = 0.5f;

	float startTime, totalDistance;

	// Use this for initialization
	IEnumerator Start () {
		startTime = Time.time;
		totalDistance =  Vector3.Distance(startPos.position, endPos.position);
		while(repeatable) {
			yield return RepeatLerp(startPos.position, endPos.position, 3.0f);
			yield return RepeatLerp(endPos.position, startPos.position, 3.0f);

		}
	}
	
	// Update is called once per frame
	void Update () {
		if(!repeatable) {
			float currentDuration = (Time.time - startTime) * speed; //Get Current Duration, basically where the object is at 
			float journeyFraction = currentDuration / totalDistance; //How far along in the lerp we are
			this.transform.position = Vector3.Lerp(startPos.position, endPos.position, journeyFraction); //Update our position based on how far along we are		}	
		}
	}
	
	public IEnumerator RepeatLerp(Vector3 a, Vector3 b, float time) {
		float i = 0.0f; 
		float rate = (1.0f / time) * speed; //1 is total amount we need to travel
		while (i < 1.0f) { //while we have not reached our destination
			i += Time.deltaTime * rate; 
			this.transform.position = Vector3.Lerp(a,b,i); //Update position
			yield return null;
		}

	}
}
