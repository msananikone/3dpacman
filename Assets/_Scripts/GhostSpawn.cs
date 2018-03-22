using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostSpawn : MonoBehaviour 
{
		public LifeController playerHealth;       // Reference to the player's heatlh.
		public GameObject enemy;                // The enemy prefab to be spawned.
		public float spawnTime = 3f;            // How long between each spawn.
		public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.


		void Start ()
		{
			// Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
			//InvokeRepeating ("Spawn", spawnTime, spawnTime);

		for (int spawnPointIndex = 0; spawnPointIndex < 1; spawnPointIndex++) {

			// Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
			Instantiate (enemy, spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);
		}
	}
}