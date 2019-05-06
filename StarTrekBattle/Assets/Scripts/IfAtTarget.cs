using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IfAtTarget : MonoBehaviour {

    public GameObject target;
    public Vector3 heading;
    public Canvas canvas=null;

    public string scene;

    bool fade = false;
    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        heading = target.transform.position - transform.position;
        //Debug.Log(heading.sqrMagnitude);

        if(heading.sqrMagnitude < 500 && canvas == null)
        {
            SceneManager.LoadScene(scene);
        }

        if(canvas!=null)
        {
            if (heading.sqrMagnitude < 1000)
            {
                fade = true;
            }

            if (fade)
            {
                canvas.GetComponent<CanvasGroup>().alpha += 0.01f;
                GetComponent<AudioSource>().volume += -0.01f;
            }

            if (canvas.GetComponent<CanvasGroup>().alpha == 1)
            {
                SceneManager.LoadScene(scene);
            }
        }
    }
}
