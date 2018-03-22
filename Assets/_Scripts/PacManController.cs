using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PacManController : MonoBehaviour {
	private Transform target;
	private NavMeshAgent agent;

	private Vector3 initPosition = Vector3.zero;

	public GameObject pacman;

	private Rigidbody myRigidbody;

	public GameController theGameController;
	public LifeController theLifeController;
	public ScoreController theScoreController;

	public AudioClip ateDotClip;
	private AudioSource ateDot;

	// Use this for initialization
	void Start () {
		agent = gameObject.GetComponent<NavMeshAgent> ();
		initPosition = transform.position;

		ateDot = gameObject.AddComponent< AudioSource>();

		Restart ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {
			RaycastHit hit;
			if (Physics.Raycast (Camera.main.ScreenPointToRay (Input.mousePosition), out hit, 100)) {
				agent.destination = hit.point;
			}
		}
	}

	void Restart(){
		transform.position = initPosition;
	}

	public void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "dot") 
		{
			/*
			ateDot.clip = ateDotClip;
			ateDot.Play ();

			//Debug.Log ("ate dot");
			transform.position = Vector3.one * 9999f; // move the game object off screen while it finishes it's sound, then destroy it
			Destroy(gameObject, ateDotClip.length);
			*/
			theScoreController.addScore ();
		}
		if (collision.gameObject.tag == "ghost") {
			theLifeController.takeLife ();
		}
	}
}
