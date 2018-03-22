using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public void click_to_play()
	{
		SceneManager.LoadScene (1);
	}
}
