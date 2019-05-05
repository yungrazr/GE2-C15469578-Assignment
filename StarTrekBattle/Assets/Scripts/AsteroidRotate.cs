using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidRotate : MonoBehaviour {

    [SerializeField]
    private float tumble;

    // Use this for initialization
    void Start () {
        foreach (Transform child in transform)
        {
            child.GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
