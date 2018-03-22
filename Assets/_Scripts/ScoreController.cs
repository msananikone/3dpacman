using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {
	public Text scoreText;
	public float scoreCount;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "Score: " + scoreCount;
	}

	public void addScore()
	{
		scoreCount++;
	}
}
