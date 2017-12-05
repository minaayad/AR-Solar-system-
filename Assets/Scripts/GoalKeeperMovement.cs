﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalKeeperMovement : MonoBehaviour {
	
		public GameObject rightpoint;
		public GameObject leftpoint;
		public GameObject middlepoint;
	// Use this for initialization
	public float speed = 0.000005F;
		private float startTime;
		private float journeyLength;
		Transform start; 
		Transform end;

		bool move  = false;

	void Start () {
		startTime = Time.time;
		//keep ();
		//MoveObjectLerp (this.transform, middlepoint.transform.position, rightpoint.transform.position,2000f);
	}
	
	// Update is called once per frame
	void Update () {
		if (move) {
			float distCovered = (Time.time - startTime) * speed / 13;
			float fracJourney = distCovered / journeyLength;
			transform.position = Vector3.Lerp (start.position, end.position, fracJourney);
			if (distCovered > journeyLength) {
				move = false;
			}
		}
	}



		/*
		 void MoveObjectLerp ( Transform thisTransform ,Vector3 startPos  , Vector3 endPos  ,float timem  ) {
		
		journeyLength = Vector3.Distance(startPos, endPos);
		
		float z = 0.0f;

		float rate = 1.0f/timem;

	while (z < 1.0f) {

		z += Time.deltaTime * rate;

		thisTransform.position = Vector3.Lerp(startPos, endPos, z);

			//yield;

	}
		*/

	 void  goRight (){
		startTime = Time.time;
		start = middlepoint.transform;
		end = rightpoint.transform;
		journeyLength = Vector3.Distance(start.position, end.position);
		move = true;

	}
	 void  goLeft(){
		startTime = Time.time;
		start = middlepoint.transform;
		end = leftpoint.transform;
		journeyLength = Vector3.Distance(start.position, end.position);
		move = true;

	}
	public  void keep(){
	
		int ran =(int) Random.Range (1f, 3f);
		switch (ran) {
		case 1:
			goRight ();
			break;
		case 2:
			goLeft ();
			break;
		}
	}
	public void  gomiddle(){
		startTime = Time.time;
		start = transform;
		end = middlepoint.transform;
		journeyLength = Vector3.Distance(start.position, end.position);
		move = true;

	}


} 
	
