using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCubes : MonoBehaviour {

	public GameObject cubePrefab;



	// Use this for initialization
	void Start () {

		//Generate the wall
		for(int i=0;i<3;i++){
			for (int j=0; j < 10; j++) {				

				GameObject bonusA = (GameObject)Instantiate (cubePrefab, new Vector3(j,i+0.5f,this.transform.position.z), Quaternion.identity,gameObject.transform);					

			}
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
