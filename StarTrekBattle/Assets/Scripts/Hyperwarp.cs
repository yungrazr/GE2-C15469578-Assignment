using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Hyperwarp : MonoBehaviour {

    public Camera maincamera;
    Vector3 offset;
    public GameObject target;
    Vector3 heading;

    public GameObject fade;
    bool fading = false;
 

	// Use this for initialization
	void Start () {
        //offset = transform.position - maincamera.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        //maincamera.transform.position = transform.position - offset;
        heading = target.transform.position - transform.position;
        if (heading.sqrMagnitude < 20 * 20)
        {
            if (transform.localScale.z < 10 && maincamera.fieldOfView < 160)
            {
                GetComponent<AudioSource>().enabled = true;
                transform.localScale += new Vector3(0, 0, 0.05f);
                maincamera.fieldOfView += 0.5f;
            }
            else
            {
                transform.position += transform.forward * 100;
                fading = true;
            }
        }

        if(fading)
        {
            fade.GetComponent<CanvasGroup>().alpha += 0.002f;
        }

        if (fade.GetComponent<CanvasGroup>().alpha == 1)
        {
            SceneManager.LoadScene("Menu");
        }


    }
}
