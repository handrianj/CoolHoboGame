using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	public Vector3 positionStart;

	public Vector3 positionEnd;

	public float speed;

	private Vector3 target;

	// Use this for initialization
	void Start () {
		target = positionEnd;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards(transform.position,target, speed * Time.deltaTime);

		if (gameObject.transform.position == target) {

			if(target == positionEnd)
				target = positionStart;
			else
				target = positionEnd;
		}
	}

	void Update(int test){

	}

	void Update(bool vatefaire){
	}
}
