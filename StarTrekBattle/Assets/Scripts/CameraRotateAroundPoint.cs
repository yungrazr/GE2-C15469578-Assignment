using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotateAroundPoint : MonoBehaviour {

    public GameObject target;
    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(target.transform);
        transform.Translate(Vector3.right * Time.deltaTime* speed);
    }
}
