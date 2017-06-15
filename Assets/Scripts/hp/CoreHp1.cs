using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoreHp1 : MonoBehaviour {
    private int hp;
	// Use this for initialization
	void Start () {
       
        
    }
	
	// Update is called once per frame
	void Update () {
        hp = GameObject.Find("Player1Core(Clone)").GetComponent<Property>().health;
        GameObject.Find("CoreHp1").GetComponent<Text>().text = "Hp :" + hp;

    }
}
