using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public GameObject target;

    // Use this for initialization
    void Start () {
        transform.LookAt(target.transform);
        Destroy(gameObject, 2);
    }
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.forward/2;
	}


    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
