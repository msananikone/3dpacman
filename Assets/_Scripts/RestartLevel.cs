using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour {
	public void OnTriggerEnter(Collider collider)
	{
		if (collider.tag == "pacman") {
			//SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
		}
	}
}
