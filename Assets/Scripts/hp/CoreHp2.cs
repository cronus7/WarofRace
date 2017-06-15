using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoreHp2 : MonoBehaviour
{
    private int hp;
    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        hp = GameObject.Find("Player2Core(Clone)").GetComponent<Property>().health;
        GameObject.Find("CoreHp2").GetComponent<Text>().text = "Hp :" + hp;

    }
}

