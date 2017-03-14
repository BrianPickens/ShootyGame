using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementScript : MonoBehaviour {

	public Transform Target;
	public float speedMin;
	public float speedMax;
	private float speed;

	// Use this for initialization
	void Start () {
		Target = GameObject.FindGameObjectWithTag ("Player").transform;
		speed = Random.Range (speedMax, speedMax);
	}
	
	// Update is called once per frame
	void Update () {
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards (transform.position, Target.position, step);
		transform.LookAt (Target.position);
	}
}
