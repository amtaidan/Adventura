using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour {
	public float speed;
	CharacterController jimmy;
	// Use this for initialization
	void Start () {
		jimmy = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		float horizontal = Input.GetAxis("Horizontal"); //this gives the joystick left and right input
		float vertical = Input.GetAxis("Vertical");
		jimmy.Move(transform.forward *Time.deltaTime *vertical *speed);
		jimmy.Move (transform.right * Time.deltaTime * horizontal * speed);
		transform.Rotate (0, Input.GetAxis ("Mouse X") * Time.deltaTime * 80f, 0);

	}
}
