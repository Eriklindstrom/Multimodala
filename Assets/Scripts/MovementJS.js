#pragma strict

//public float moveSpeed;
var moveSpeed = 40f;

function Start () {
	
	var moveSpeed = 40f;
}

function Update () {
	var moveSpeed = 40f + Time.time;
	var inputVector : Vector3 = Vector3(moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime, moveSpeed*Input.GetAxis("Vertical")*Time.deltaTime,moveSpeed*Time.deltaTime);
	GetComponent(CharacterController).SimpleMove(inputVector * 100);
	//transform.Translate(moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime,moveSpeed*Input.GetAxis("Vertical")*Time.deltaTime,moveSpeed*Time.deltaTime);
	//Debug.Log (moveSpeed);
}
