using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public Button PickScene;
    public Button PlayAll;

    public bool active=false;
    public GameObject SceneButtons;

    public Button Scene1;
    public Button Scene2;
    public Button Scene3;
    public Button Scene4;
    public Button Scene5;
    public Button Scene6;
    public Button Scene7;


    // Use this for initialization
    void Start () {
        PickScene.onClick.AddListener(Pickscene);
        PlayAll.onClick.AddListener(Playall);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void Playall()
    {
        SceneManager.LoadScene("Scene1 Intro");
    }

    void Pickscene()
    {
        active = !active;
        SceneButtons.SetActive(active);
    }
}
