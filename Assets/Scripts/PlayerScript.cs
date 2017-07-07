using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour {

	public static int playerHealth = 50;
	public GameObject gun;
	public AudioSource shot;
	public AudioClip gunshot;
	// Use this for initialization
	void Start () {
		shot = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			shot.PlayOneShot(gunshot);
			Debug.Log("move");
			gun.transform.Translate (.5f, 0f, 0f);
			new WaitForSeconds(2);
			gun.transform.Translate (-.5f, 0f, 0f);
		}
		if (playerHealth == 0) {
			LoadLevel ();
		}
	}
	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == "Rhizopa") {
			playerHealth -= 10;
			Debug.Log (playerHealth);
		}
		if (other.gameObject.tag == "RhizBoss") {
			playerHealth -= 20;
			Debug.Log (playerHealth);
		}
	}
		public void LoadLevel(){
			SceneManager.LoadScene ("Lose");
		}
	}

