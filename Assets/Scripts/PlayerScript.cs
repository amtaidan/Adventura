using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public static int playerHealth = 50;
	public GameObject gun;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			Debug.Log("move");
			gun.transform.Translate (.5f, 0f, 0f);
			new WaitForSeconds(2);
			gun.transform.Translate (-.5f, 0f, 0f);
		}
	}
}
