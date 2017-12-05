using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickplatDetails : MonoBehaviour {

	public Text text;
	private Animator anim;
	public AudioClip impact;
	 AudioSource audioSource;
     public GameControll gamecontroll;
     public int i;
     private AudioSource[] allAudioSources  ;



	public Animator [] otheranimis;

	void Start(){
		audioSource = GetComponent<AudioSource>();
		anim = GetComponent<Animator> ();
        allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];

	}

	// Use this for initialization
	public void click (string details) {
        foreach (AudioSource audioS in allAudioSources)
        {
            audioS.Stop();
        }
		audioSource.PlayOneShot(impact, 1F);

        audioSource.PlayDelayed(2f);
		text.text = details;
		anim.SetBool("IsTouched",true);

		for (int i = 0; i < otheranimis.Length; i++) {
			otheranimis [i].SetBool ("IsTouched", false);
		}
        GameObject Instantiate = this.gameObject;
        gamecontroll.OpenPanel(Instantiate,i);
	}
}
