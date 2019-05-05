using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowBehind : MonoBehaviour {

    public GameObject target;
    //Vector3 offset;
    Vector3 newPos;
    Quaternion newRot;
    public bool front;

    // Use this for initialization
    void Start () {
        //offset = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        if(front)
        {
            frontCamera();
        }
        else
        {
            backCamera();
        }
    }

    void backCamera()
    {
        newPos = target.transform.position - target.transform.forward * 50;
        transform.position = newPos + transform.up * 5;
        transform.LookAt(target.transform);

        newRot = target.transform.rotation;
        transform.rotation = newRot;
    }

    void frontCamera()
    {
        newPos = target.transform.position + target.transform.forward * 50;
        transform.position = newPos;

        transform.LookAt(target.transform);
    }

}
