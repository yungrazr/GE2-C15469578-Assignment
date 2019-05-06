using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullets : MonoBehaviour {

    public GameObject bulletPrefab;
    public GameObject target;

    Vector3 pos;


	// Use this for initialization
	void Start () {
        StartCoroutine(Shoot());
	}
	
	// Update is called once per frame
	void Update () {


    }

    IEnumerator Shoot()
    {
        yield return new WaitForSeconds(3);
        while (target!=null)
        {
            var delay = Random.Range(0.0f, 0.5f);
            yield return new WaitForSeconds(delay);
            pos = transform.position;
            GameObject bullet = Instantiate(bulletPrefab, pos, Quaternion.identity);
            bullet.GetComponent<Bullet>().target = target;
            bullet.GetComponent<Bullet>().parent = gameObject;
            yield return new WaitForSeconds(0.3f);
            pos = transform.position;
            bullet = Instantiate(bulletPrefab, pos, Quaternion.identity);
            bullet.GetComponent<Bullet>().target = target;
            bullet.GetComponent<Bullet>().parent = gameObject;
            delay = Random.Range(1.5f, 2.0f);
            yield return new WaitForSeconds(delay);
        }

    }
}
