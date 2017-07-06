using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RhizopaCombat : MonoBehaviour {
	public int rhizHealth = 30;
	public int rhizbossHealth = 300;
	public static int damage = 5;
	public bool newGun = false;
	public int enemyCount = 4;
	public GameObject door;
	public static ParticleSystem pSystem;
	public Transform player;
	public float walkingDistance = 30.0f;
	public float smoothTime = 2.0f;
	private Vector3 smoothVelocity = Vector3.zero*10.0f;

	// Use this for initialization
	void Start () {
		pSystem = GetComponent<ParticleSystem> ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (player);
		float distance = Vector3.Distance (transform.position, player.position);
		if (distance < walkingDistance) {
			transform.position = Vector3.SmoothDamp (transform.position, player.position, ref smoothVelocity, smoothTime);
		}
		if (rhizHealth == 0) {
			enemyCount--;
			gameObject.SetActive(false);
			newGun = true;
			Debug.Log (enemyCount);
		}

		if (enemyCount == 0) {
			door.SetActive (false);
		}
		if (newGun == true) {
			damage = 15;

		}
	}
}