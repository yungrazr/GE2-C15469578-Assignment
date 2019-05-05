using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShips : MonoBehaviour {

    public GameObject EnemyShipPrefab;
    public GameObject target;
    Vector3 mothershipPos;
    public bool spawned=false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (this.GetComponent<Arrive>().heading.sqrMagnitude < 1 && spawned == false)
        {
            spawnShips();
        }

    }

    void spawnShips()
    {
        spawned = true;
        mothershipPos = transform.position;
        for (int i = 0; i < 5; i++)
        {
                GameObject prefab = Instantiate(EnemyShipPrefab, mothershipPos, Quaternion.identity);
                prefab.GetComponent<Seek>().target = transform.position - transform.up * 25 + transform.forward * 5 * i;
                prefab.GetComponent<Seek>().target2 = target;
        }
    }
}
