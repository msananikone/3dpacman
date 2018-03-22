using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatDot : MonoBehaviour {
	private ScoreController theScoreController;

	public AudioClip ateDotClip;
	private AudioSource ateDot;

	// Use this for initialization
	void Start () {
		ateDot = GetComponent<AudioSource> ();
		theScoreController = FindObjectOfType<ScoreController> ();
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "pacman")
		{

			//ateDot = new AudioSource ();
			ateDot.clip = ateDotClip;
			ateDot.Play ();

			//Debug.Log ("ate dot");

			transform.position = Vector3.one * 9999f; // move the game object off screen while it finishes it's sound, then destroy it
			Destroy(gameObject, ateDotClip.length);

			theScoreController.addScore ();
		}
	}
}
