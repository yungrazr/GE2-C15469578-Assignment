using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullets : MonoBehaviour {

    public GameObject bulletPrefab;
    public GameObject target;

    Vector3 pos;


	// Use this for initialization
	void Start () {
        pos = transform.position;
        StartCoroutine(Shoot());
	}
	
	// Update is called once per frame
	void Update () {


    }

    IEnumerator Shoot()
    {
        while(target!=null)
        {
            GameObject bullet = Instantiate(bulletPrefab, pos, Quaternion.identity);
            bullet.GetComponent<Bullet>().target = target;
            yield return new WaitForSeconds(0.2f);
            bullet = Instantiate(bulletPrefab, pos, Quaternion.identity);
            bullet.GetComponent<Bullet>().target = target;
            var delay = Random.Range(1.0f, 2.0f);
            yield return new WaitForSeconds(delay);
        }

    }
}
