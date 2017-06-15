using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class createCore : MonoBehaviour {

	// Use this for initialization
	void Start () {

        GameObject core1 = (GameObject)Instantiate(Resources.Load("prefabs/Player1Core"));
        core1.transform.position = new Vector2(-15, -9);
        GameObject core2 = (GameObject)Instantiate(Resources.Load("prefabs/Player2Core"));
        core2.transform.position = new Vector2(33, -9);
    }
	
	// Update is called once per frame
	void Update () {
    }
}
