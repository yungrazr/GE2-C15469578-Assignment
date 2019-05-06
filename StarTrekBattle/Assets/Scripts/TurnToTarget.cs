using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnToTarget : MonoBehaviour {

    public GameObject target;
    Vector3 targetPos;

    public GameObject voice;

    public SpawnShips spawn;
    public float slowRot=3;
    public float slowMovement=5;


	// Use this for initialization
	void Start () {
        targetPos = target.transform.position;

    }
	
	// Update is called once per frame
	void Update () {
        if(spawn.spawned ==true)
        {
            if(voice!=null)
            {
                voice.SetActive(true);
            }
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(targetPos), Time.deltaTime / slowRot);
            transform.position += transform.forward/ slowMovement;
        }
    }
}
