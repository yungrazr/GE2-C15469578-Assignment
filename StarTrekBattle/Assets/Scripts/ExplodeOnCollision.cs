using UnityEngine;
using System.Collections;

public class ExplodeOnCollision : MonoBehaviour
{
    public GameObject explosionPrefab;
    public Wander wander;

    void OnCollisionEnter(Collision col)
    {
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        wander.shipsAlive--;
        Destroy(gameObject);
    }

}