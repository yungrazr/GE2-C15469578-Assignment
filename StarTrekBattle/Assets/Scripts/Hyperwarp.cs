using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hyperwarp : MonoBehaviour {

    public Camera maincamera;
    Vector3 offset;

	// Use this for initialization
	void Start () {
        //offset = transform.position - maincamera.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        //maincamera.transform.position = transform.position - offset;

        if (transform.localScale.z < 10 && maincamera.fieldOfView < 160)
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
