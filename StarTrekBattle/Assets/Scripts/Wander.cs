using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Wander : SteeringBehaviour
{
    public GameObject targetGameObject = null;
    public Vector3 target = Vector3.zero;

    public Vector3 heading;
    public GameObject target1;
    public GameObject target2;
    public GameObject target3;
    public GameObject target4;
    public string scene = null;

    public int shipsAlive = 6;
    public int currentTarget = 1;


    public void OnDrawGizmos()
    {
        if (isActiveAndEnabled && Application.isPlaying)
        {
            Gizmos.color = Color.cyan;
            if (targetGameObject != null)
            {
                target = targetGameObject.transform.position;
            }
            Gizmos.DrawLine(transform.position, target);
        }
    }

    public override Vector3 Calculate()
    {
        return boid.SeekForce(target);
    }

    public void Update()
    {
        heading = target - transform.position;
        if (targetGameObject != null)
        {
            target = targetGameObject.transform.position;
        }
        //Debug.Log(heading.sqrMagnitude);
        if (shipsAlive>0)
        {
            if (heading.sqrMagnitude < 20 * 20 && currentTarget == 1)
            {
                targetGameObject = target2;
                heading = target2.transform.position - transform.position;
                currentTarget = 2;
            }

            if (heading.sqrMagnitude < 20 * 20 && currentTarget == 2)
            {
                targetGameObject = target3;
                heading = target3.transform.position - transform.position;
                currentTarget = 3;
            }

            if (heading.sqrMagnitude < 20 * 20 && currentTarget == 3)
            {
                targetGameObject = target1;
                heading = target1.transform.position - transform.position;
                currentTarget = 1;
            }
        }
        else
        {
            targetGameObject = target4;
        }


    }
}