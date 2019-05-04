using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hyperwarp : MonoBehaviour {

    public Camera maincamera;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.localScale.z < 10 && maincamera.fieldOfView < 160)
        {
            transform.localScale += new Vector3(0, 0, 0.1f);
            maincamera.fieldOfView += 2;
        }
        else
        {
            transform.position += transform.forward * 10;
        }


	}
}
