using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour {

	public GameObject Enemy;
	public float spawnTime;
	private float respawn;

	// Use this for initialization
	void Start () {
		respawn = spawnTime;
	}
	
	// Update is called once per frame
	void Update () {

		respawn -= Time.deltaTime;
		if (respawn < 0) {
			Instantiate (Enemy, transform.position, transform.rotation);
			respawn = spawnTime;
		}

	}
}
