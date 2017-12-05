using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalDetector : MonoBehaviour {
	public Text goal;
	int goalCount =0;
	public GameObject ball;

	public  GameObject firework;

	// Use this for initialization
	void Start () {
		goal.text = "Goals : "+ goalCount.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other) {
		goalCount++;
		goal.text = "Goals : "+goalCount.ToString();
		if (goalCount > 4) {
			goalCount = 0;
			goal.text = "Goals : "+goalCount.ToString();
			firework.SetActive (true);
		}
		//Destroy(other.gameObject);
		StartCoroutine(waitAndRest());
	
	}
	IEnumerator waitAndRest()
	{
		
		yield return new WaitForSeconds(5);
		ball.GetComponent<resetball>().reset();
		firework.SetActive (false);

	}
}
