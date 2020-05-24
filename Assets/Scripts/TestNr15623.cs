using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestNr15623 : MonoBehaviour {	

	private int score;

	public Text countText;
	public Text endText;
	public Text timerText;
	private float startTime;

	public float moveSpeedRotation;
	public float moveSpeed;

	public Rigidbody rb;
	public AudioSource audio;
	public int children;

	void Start() {
		score = 0;
		moveSpeedRotation = (80f);
		moveSpeed = (40f);
		audio = GetComponent<AudioSource>();
		//changing texts
		SetCountText ();
		endText.text = "";
		startTime = Time.time;
		
		
	}

	void Update()
	{

		if(score == children){
			//Debug.Log("Klar");
			transform.Rotate(0,0,0);
			transform.Translate(0,0,0);
		} else {
			//Debug.Log ("Children = " + children);
			//FÖR XBOX-KONTROLLEN
			//var x = Input.GetAxis("Oculus_GearVR_RThumbstickX") * Time.deltaTime * moveSpeedRotation;
			//var y = Input.GetAxis("Yculus_GearVR_RThumbstickY") * Time.deltaTime * moveSpeedRotation;

			//FÖR TANGENTBORD SÅ FELIX SLIPPER KÖPA EN XBOX-KONTROLLER
			var x = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeedRotation;
			var y = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeedRotation;

			var force = Time.deltaTime * moveSpeed;
			var rotateVector = new Vector3 (-x, y, 0);

			transform.Rotate (rotateVector);
			transform.Translate(0, 0, force);

		}
		//updating time text
		float t = Time.time - startTime;
		string minutes = ((int)t / 60).ToString ();
		string seconds = (t % 60).ToString ("f2");
		timerText.text =  "Time: " + minutes + ":" + seconds;


	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Ring"))
		{
			other.gameObject.SetActive (false);
			score += 1;
			SetCountText ();
			audio.Play();
		}
		if (other.gameObject.CompareTag ("RingGoal")) {
			score += 1;
			SetCountText();
			float t = Time.time - startTime;
			string minutes = ((int)t / 60).ToString ();
			string seconds = (t % 60).ToString ("f2");
			endText.text = "Simulator ended\nYou scored " + score.ToString () + " rings \nin " + minutes + " minutes and " + seconds + " seconds";
			//Fulkod, för att gå in i ifsatsen i update som stannar spelaren
			score = children;
		}


	}

	//updating count text 
	void SetCountText ()
	{
		countText.text = "Count: " + score.ToString ();
	}
}
