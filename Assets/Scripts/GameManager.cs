using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class GameManager : MonoBehaviour {


	public static bool State = false;
	public static bool ballShoted = false;
	// Use this for initialization
	AudioSource audioSource;
	public AudioClip impact;
	void Start () {
		audioSource = GetComponent<AudioSource>();
		StartCoroutine(beeep(2));

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void beep(){
		audioSource.PlayOneShot(impact, 1F);
	}





	IEnumerator beeep(int x)
	{
		yield return new WaitForSeconds(3);
		beep ();
		State = true;
	}
}
