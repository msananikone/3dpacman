using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	public PacManController pacman;
	private Vector3 pacmanStartPoint;

	//private ScoreController theScoreController;
	// Use this for initialization
	void Start () {
		pacmanStartPoint = pacman.transform.position;

		//theScoreController = FindObjectOfType<ScoreController> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void RestartGame(){
		StartCoroutine ("RestartGameCo");
	}

	public IEnumerator RestartGameCo(){
		pacman.gameObject.SetActive (false);
		yield return new WaitForSeconds (3f);

		pacman.transform.position = pacmanStartPoint;
		pacman.gameObject.SetActive (true);

		//theScoreController.scoreCount = 0;
	}
}
