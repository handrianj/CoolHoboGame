using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour {

	public GameObject shotPrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//On click
		if (Input.GetMouseButtonUp (0)) {

			//Generate the bonus
			GameObject bonusA = (GameObject)Instantiate (shotPrefab, this.transform.position, Quaternion.identity);	

			//Set right orientation and shoot it
			Rigidbody body =  bonusA.GetComponent<Rigidbody> ();
			bonusA.transform.eulerAngles = this.transform.eulerAngles;
			body.AddForce (bonusA.transform.forward*2000);
		}
	}
}
