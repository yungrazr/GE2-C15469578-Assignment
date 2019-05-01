using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Arrive : SteeringBehaviour
{
    public Vector3 targetPosition = Vector3.zero;
    public float slowingDistance = 15.0f;

    public GameObject targetGameObject = null;
    public Vector3 heading;

    public override Vector3 Calculate()
    {
        return boid.ArriveForce(targetPosition, slowingDistance);
    }

    public void Update()
    {
        heading = targetPosition - transform.position;
        if (targetGameObject != null)
        {
            targetPosition = targetGameObject.transform.position;
        }

        Debug.Log(heading.sqrMagnitude);
        if (heading.sqrMagnitude < 200)
        {
            boid.acceleration = Vector3.Lerp(boid.acceleration, Vector3.zero, Time.deltaTime);
            boid.velocity = Vector3.Lerp(boid.velocity, Vector3.zero, Time.deltaTime);
        }

        if (heading.sqrMagnitude < 1)
        {
            boid.acceleration = Vector3.zero;
            boid.velocity = Vector3.zero;
            this.enabled = false;
        }
    }
}