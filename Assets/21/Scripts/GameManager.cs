using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	private int nbCubes;

	public Transform allCubesNode;

	public GameObject cubePrefab;

	// Use this for initialization
	void Start () {
		GenerateCubes ();
	}

	public void CubeDestroyed () {
		nbCubes--;

		if (nbCubes <= 0) {
			GenerateCubes ();
		}
	}

	private void GenerateCubes(){
		
		//Generate the wall
		for(int i=0;i<3;i++){
			for (int j=0; j < 10; j++) {				

				GameObject bonusA = (GameObject)Instantiate (cubePrefab, new Vector3(j,i+0.5f,allCubesNode.position.z), Quaternion.identity,allCubesNode);					
				nbCubes++;

				bonusA.GetComponent<Cube> ().AddListener (this);
			}
		}

	}
}
