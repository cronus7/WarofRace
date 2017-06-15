using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldSystem2 : MonoBehaviour
{
    public float gold;

    // Use this for initialization
    void Start()
    {
        gold = 2000;


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gold += 0.75f;        
        GameObject.Find("P2Gold").GetComponent<Text>().text = "Player2 Gold :" + (int)gold;
    }
}
