using UnityEngine;
using System.Collections;

public class ExplodeOnCollision : MonoBehaviour
{
    public GameObject explosionPrefab;

    void OnCollisionEnter(Collision col)
    {
        GameObject explosion = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        GetComponent<OffsetPursue>().enabled = false;
        Destroy(gameObject);
    }

}