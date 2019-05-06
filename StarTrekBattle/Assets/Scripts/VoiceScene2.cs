using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceScene2 : MonoBehaviour {

    public AudioClip one;
    public AudioClip two;
    public AudioClip three;
    public AudioClip four;
    public AudioClip five;

    public AudioSource theme;

    public FadeOutFadeIn fade;

    AudioSource audioSource;
    int currentPlaying = 1;

    // Use this for initialization
    void Start () {
        audioSource=GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
            if(currentPlaying==1 && !audioSource.isPlaying)
            {
                audioSource.clip = two;
                audioSource.Play();
                currentPlaying = 2;
            }

            if (currentPlaying == 2 && !audioSource.isPlaying)
            {
                audioSource.clip = three;
                audioSource.Play();
                currentPlaying = 3;
            }

            if (currentPlaying == 3 && !audioSource.isPlaying )
            {
                audioSource.clip = four;
                audioSource.Play();
                currentPlaying = 4;
            }

            if (currentPlaying == 4 && !audioSource.isPlaying )
            {
                audioSource.clip = five;
                audioSource.Play();
                currentPlaying = 5;
            }

            if (currentPlaying == 5 && !audioSource.isPlaying)
            {
            theme.volume -= 0.01f;
                fade.fading = false;

            }
    }
}
