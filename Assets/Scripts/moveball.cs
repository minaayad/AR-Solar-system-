using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveball : MonoBehaviour {
	public Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		//rb.velocity = new Vector3 (0, 10, 0);
		//rb.AddForce(new Vector3(0,100f,0));
	}
	public float minSwipeDistY;

	public float minSwipeDistX;

	private Vector2 startPos;

	// Update is called once per frame
	void Update () {

		//#if UNITY_ANDROID
		if (Input.touchCount > 0) 

		{

			Touch touch = Input.touches[0];



			switch (touch.phase) 

			{

			case TouchPhase.Began:

				startPos = touch.position;

				break;



			case TouchPhase.Ended:

				float swipeDistVertical = (new Vector3(0, touch.position.y, 0) - new Vector3(0, startPos.y, 0)).magnitude;

				if (swipeDistVertical > minSwipeDistY) 

				{

					float swipeValue = Mathf.Sign(touch.position.y - startPos.y);

					//		if (swipeValue > 0)//up swipe

					//Jump ();

					//	else if (swipeValue < 0)//down swipe

					//Shrink ();
					Debug.Log (swipeValue.ToString());
					if (GameManager.State) {
						rb.AddForce (new Vector3 (0, swipeValue * 30, 60f));
					}

				}

				float swipeDistHorizontal = (new Vector3(touch.position.x,0, 0) - new Vector3(startPos.x, 0, 0)).magnitude;

				if (swipeDistHorizontal > minSwipeDistX) 

				{

					float swipeValue = Mathf.Sign(touch.position.x - startPos.x);

					//	if (swipeValue > 0)//right swipe

					//MoveRight ();

					//		else if (swipeValue < 0)//left swipe

					//MoveLeft ();

					Debug.Log (swipeValue.ToString());
					if (GameManager.State) {
						rb.AddForce (new Vector3 (swipeValue * 25, 0, 60f));
					}
				}
				break;
			}
		}
		
	}
}
