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
		if (Input.GetKey (KeyCode.Space)) {
			transform.Translate (0f, 3f*Time.deltaTime, 0f);
		}
		if (Input.GetKey (KeyCode.LeftShift)) {
			transform.Translate (0f, -3f*Time.deltaTime, 0f);
		}
		if (Input.GetKey (KeyCode.LeftShift)) {
			speed = 15;
		}
	}
}
