using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTarget : MonoBehaviour {

    public GameObject[] targetList;
    public GameObject target;

    public FadeOutFadeIn fade;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(target==null)
        {
            NewTarget();
        }

        checkIfNoEnemies();
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

    void checkIfNoEnemies()
    {
        var dead = 0;
        for (int i = 0; i< targetList.Length; i++)
        {
            if(targetList[i]==null)
            {
                dead++;
            }
        }

        if(dead>=5)
        {
            fade.fading = false;
        }

    }

}
