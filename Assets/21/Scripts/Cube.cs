using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

	//Set game manager as listener to restart the game if necesarry
	private GameManager manager;

	void Awake(){
		//Random color
		gameObject.GetComponent<Renderer>().material.color=new Color (Random.value, Random.value, Random.value);
	}

	void OnCollisionEnter(Collision col){

		//Hit by shot, kill the cube
		if (col.collider.name.Contains("Shot")) {
			
				manager.CubeDestroyed ();
				Destroy (this.gameObject);
			}
		}


	public void AddListener(GameManager manager){
		this.manager = manager;
	}
}
