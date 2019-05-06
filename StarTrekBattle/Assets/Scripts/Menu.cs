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
        Scene1.onClick.AddListener(delegate { ChangeScene("Scene1 Intro"); });
        Scene2.onClick.AddListener(delegate { ChangeScene("Scene2 Encounter"); });
        Scene3.onClick.AddListener(delegate { ChangeScene("Scene3 Battle"); });
        Scene4.onClick.AddListener(delegate { ChangeScene("Scene4 Mothership"); });
        Scene5.onClick.AddListener(delegate { ChangeScene("Scene5 Chase"); });
        Scene6.onClick.AddListener(delegate { ChangeScene("Scene6 Chase 2"); });
        Scene7.onClick.AddListener(delegate { ChangeScene("Scene7 Escape"); });

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

    void ChangeScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
