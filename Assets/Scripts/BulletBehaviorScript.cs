using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviorScript : MonoBehaviour {

	private bool shooting;
	private bool miss;
	private Transform target;
	public float speed;

	//burrito
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (shooting) {
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards (transform.position, target.position, step);
		}
		if (miss) {
			if (Vector3.Distance (transform.position, target.position) < 0.05f) {
				Destroy (target.gameObject);
				Destroy (this.gameObject);
			}
		}

	}

	void OnTriggerEnter (Collider other){
		if (other.gameObject.tag == "Enemy") {
			Destroy (other.gameObject);
			Destroy (target.gameObject);
			Destroy (this.gameObject);
		}

		if (other.gameObject.tag == "Border") {
			Destroy (target.gameObject);
			Destroy (this.gameObject);
		}
	}

	public void MoveBullet (Transform other){

		target = other;
		shooting = true;
	}

	public void Missed(){
		miss = true;
	}


}
