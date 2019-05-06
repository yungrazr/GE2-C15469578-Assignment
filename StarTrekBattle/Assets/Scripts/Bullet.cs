using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public GameObject parent;
    public GameObject target;
    public GameObject explosionPrefab;

    // Use this for initialization
    void Start () {
        transform.LookAt(target.transform);
        Destroy(gameObject, 4);
    }
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.forward/1.5f;
	}


    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject==parent)
        {

        }
        else
        {
            if(explosionPrefab!=null)
            {
                Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            }
            Destroy(gameObject);
        }
    }
}
