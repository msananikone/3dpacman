using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class GhostController : MonoBehaviour {
	private NavMeshAgent agent;
	public Transform target;

	public GameObject ghost;
	public LifeController theLifeController;

	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		agent.destination = target.transform.position;
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "pacman")
		{
			Debug.Log ("ghost hit pacman");
		}
	}
}
