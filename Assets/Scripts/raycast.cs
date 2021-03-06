﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast : MonoBehaviour
{

	// Use this for initialization
	Camera thisCamera;


	void Start ()
	{
		
		thisCamera = this.GetComponent<Camera> ();
		if (thisCamera == null)
			this.gameObject.SetActive (false);
	}

	void Update ()
	{
		// Mouse position is reported in screen space (measured in pixels)
		var screenPoint = Input.mousePosition;

		// Create a ray into the scene from this camera's perspective
		var ray = thisCamera.ScreenPointToRay (screenPoint);

		// Create a RaycastHit object as an output variable
		RaycastHit hit;


		// If Raycast hits something within 100 units...
		if (Physics.Raycast (ray, out hit, 100f)) {
			// ...draw a green ray extending the distance of the collision
			Debug.DrawRay (ray.origin, ray.direction * hit.distance, Color.green);
			if (Input.GetKeyDown (KeyCode.Mouse0)) {
				if (hit.transform.gameObject.tag == "Rhizopa") {
					hit.collider.gameObject.GetComponent<RhizopaCombat>().rhizHealth -= RhizopaCombat.damage;
					RhizopaCombat.pSystem.Play ();
				}
				if (hit.transform.gameObject.tag == "RhizBoss") {
					BossScript.bossHealth -= 15;
					RhizopaCombat.pSystem.Play ();
				}


			}

		}
		// Otherwise, draw a red ray extending 100 units into the distance
		else {
			Debug.DrawRay (ray.origin, ray.direction * 100f, Color.red);
		}
	}
}
