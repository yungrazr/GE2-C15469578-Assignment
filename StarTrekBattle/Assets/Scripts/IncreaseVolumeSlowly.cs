using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseVolumeSlowly : MonoBehaviour {

    public float maxVolume;
    public float increaseInterval;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(GetComponent<AudioSource>().volume< maxVolume)
        {
            GetComponent<AudioSource>().volume += increaseInterval;
        }
	}
}
