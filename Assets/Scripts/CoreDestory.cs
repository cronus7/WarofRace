using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoreDestory : MonoBehaviour {
    
    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        Property core = gameObject.GetComponent<Property>();
        if(core.teamNumber == 1)
        {
            if (core.health <= 0)
            {
            SceneManager.LoadScene("P2Win");
            }
       }
        else if(core.teamNumber == 2)
        {
            if (core.health <= 0)
            {
                SceneManager.LoadScene("P1Win");
            }
        }
	}
}
