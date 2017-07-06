using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RhizopaCombat : MonoBehaviour {
	public static int rhizHealth = 30;
	public static int rhiz1Health = 30;
	public static int rhiz2Health = 30;
	public static int rhiz3Health = 30;
	public static int rhizbossHealth = 30;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (rhizHealth == 0) {
			Destroy (gameObject);
		}
	}
}
