using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looking : MonoBehaviour {
	float upDownLook = 0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float mouseX = Input.GetAxis ("Mouse X") *Time.deltaTime *100f;
		float mouseY = Input.GetAxis ("Mouse Y") *Time.deltaTime *100f;

		upDownLook -= mouseY;
		upDownLook = Mathf.Clamp (upDownLook, -80f, 80f);

		transform.eulerAngles = new Vector3(upDownLook,transform.eulerAngles.y, 0f);
	}
}
