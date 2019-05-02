using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Seek : SteeringBehaviour
{
    public GameObject targetGameObject = null;
    public Vector3 target = Vector3.zero;

    public Vector3 heading;
    public GameObject target2;
    public string scene;

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

        if (heading.sqrMagnitude < 20 * 20 && target2 != null)
        {
            GetComponent<Seek>().targetGameObject = target2;
        }

        if (heading.sqrMagnitude < 5 && scene != null)
        {
            SceneManager.LoadScene(scene);
        }
    }
}