using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotSpawn : MonoBehaviour {

	private ScoreController theScoreController;
	public GameObject dot;

	// Use this for initialization
	void Start () {
		Instantiate (dot, transform);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
