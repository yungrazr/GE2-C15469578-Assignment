using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hyperwarp : MonoBehaviour {

    public Camera maincamera;
    Vector3 offset;
    public GameObject target;
    Vector3 heading;
 

	// Use this for initialization
	void Start () {
        //offset = transform.position - maincamera.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        //maincamera.transform.position = transform.position - offset;
        heading = target.transform.position - transform.position;
        if (heading.sqrMagnitude < 20 * 20)
        {
            if (transform.localScale.z < 10 && maincamera.fieldOfView < 160)
            {
                GetComponent<AudioSource>().enabled = true;
                transform.localScale += new Vector3(0, 0, 0.1f);
                maincamera.fieldOfView += 2;
            }
            else
            {
                transform.position += transform.forward * 100;
            }
        }


	}
}
