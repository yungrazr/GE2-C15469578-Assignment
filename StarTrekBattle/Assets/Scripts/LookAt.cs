using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour {

    public GameObject Target;
    Transform target;

	// Use this for initialization
	void Start () {
        target = Target.transform;
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(target);
    }
}
