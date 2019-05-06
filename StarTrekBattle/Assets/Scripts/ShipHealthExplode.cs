using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipHealthExplode : MonoBehaviour {

    int health = 3;
    public GameObject explosionPrefab;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "BulletRed(Clone)")
        {

        }
        else
        {
            health--;
            if (health == 0)
            {
                Instantiate(explosionPrefab, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }
}
