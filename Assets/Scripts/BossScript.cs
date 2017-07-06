using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossScript : MonoBehaviour {
	public Transform player;
	public float walkingDistance = 30.0f;
	public float smoothTime = 2.0f;
	private Vector3 smoothVelocity = Vector3.zero*10.0f;
	public static int bossHealth = 300;
	// Use this for initialization
	void Start () {
		
	}
	public void LoadLevel(){
		SceneManager.LoadScene ("Win");
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (player);
		float distance = Vector3.Distance (transform.position, player.position);
		if (distance < walkingDistance) {
			transform.position = Vector3.SmoothDamp (transform.position, player.position, ref smoothVelocity, smoothTime);
		}
		if (bossHealth == 0) {
			Destroy (gameObject);
			LoadLevel ();
		}
	}
}
