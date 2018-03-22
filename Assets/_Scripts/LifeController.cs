using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeController : MonoBehaviour {
	public int startingLives;

	public Text lifeText;
	public float lifeCount;

	public GameObject gameOverScreen;
	public PacManController pacman;

	public bool hasLives;
	// Use this for initialization
	void Start () {
		startingLives = 3;
	}
	
	// Update is called once per frame
	void Update () {
		if (lifeCount == 0) {
			gameOverScreen.SetActive (true);
			pacman.gameObject.SetActive (false);
		}
		lifeText.text = "x " + lifeCount;
	}

	public void takeLife(){
		lifeCount--;
	}
}
