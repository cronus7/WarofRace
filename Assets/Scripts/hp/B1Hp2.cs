using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class B1Hp2 : MonoBehaviour
{
    private int hp;
    public int lv;
    // Use this for initialization
    void Start()
    {
        lv = 1;

    }

    // Update is called once per frame
    void Update()    {

        if (GameObject.Find("Player2Bar1"))
        {
            hp = GameObject.Find("Player2Bar1").GetComponent<Property>().health;
            GameObject.Find("B1Hp2").GetComponent<Text>().text = "Hp :" + hp + " LV" + lv;
        }
        else
        {
            GameObject.Find("B1Hp2").GetComponent<Text>().text = "Hp : 0 ";
        }
    }
}