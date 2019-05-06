using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTarget : MonoBehaviour {

    public GameObject[] targetList;
    public GameObject target;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(target==null)
        {
            NewTarget();
        }
	}

    void NewTarget()
    {
        if (targetList.Length > 0)
        {
            var randomTarget = Random.Range(0, targetList.Length);
            if (targetList[randomTarget] != null)
            {
                target = targetList[randomTarget];
                GetComponent<ShootBullets>().target = target;
            }
        }

    }
}
