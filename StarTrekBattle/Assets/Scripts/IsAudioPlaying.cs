using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsAudioPlaying : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(!GetComponent<AudioSource>().isPlaying)
        {
            GetComponent<FadeOutFadeIn>().fading = false;
        }
	}
}
