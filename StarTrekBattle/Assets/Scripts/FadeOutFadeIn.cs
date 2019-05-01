using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeOutFadeIn : MonoBehaviour {

    public bool fading = true;
    public string scene;

	// Use this for initialization
	void Start () {
        GetComponent<CanvasGroup>().alpha = 0.99f;
    }
	
	// Update is called once per frame
	void Update () {
        Fade();
	}

    void Fade()
    {
        if(fading==false)
        {
            GetComponent<CanvasGroup>().alpha+= 0.01f;
        }
        if(fading==true)
        {
            GetComponent<CanvasGroup>().alpha += -0.005f ;
        }

        if(GetComponent<CanvasGroup>().alpha==1)
        {
            SceneManager.LoadScene(scene);
        }
    }
}
