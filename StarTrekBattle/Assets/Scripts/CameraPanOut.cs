using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPanOut : MonoBehaviour {

    public float slow=1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += -transform.forward * Time.deltaTime/ slow;
    }
}
