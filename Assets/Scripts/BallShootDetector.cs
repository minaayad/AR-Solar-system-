using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShootDetector : MonoBehaviour {
	public GameObject GoalKeeper;
	void start(){
	//	GoalKeeper.GetComponent<GoalKeeperMovement>().keep ();

	}

	void OnTriggerEnter(Collider other) {

		//sood
	//	GoalKeeperMovement.keep();
		GoalKeeper.GetComponent<GoalKeeperMovement>().keep ();

	}
}
