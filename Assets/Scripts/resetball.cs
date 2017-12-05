using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetball : MonoBehaviour {
	public Rigidbody rb;
	public GameObject GoalKeeper;
	// Use this for initialization
	public void reset () {
		rb = GetComponent<Rigidbody>();

		transform.position = new Vector3 (0.267924f,-1.168707f,0.8989999f);
		//reset force
		rb.velocity = Vector3.zero;
		rb.angularVelocity = Vector3.zero; 

		GoalKeeper.GetComponent<GoalKeeperMovement>().gomiddle ();
	}
	

}
