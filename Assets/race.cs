using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class race : MonoBehaviour {
    
    public int race1, race2;
	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {

        if (race1 != 0 && race2 != 0)
        {
            GameObject.Find("startbtn").GetComponent<Button>().interactable = true;
        }
    }
}
