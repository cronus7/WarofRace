using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldSystem1 : MonoBehaviour
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
        GameObject.Find("P1Gold").GetComponent<Text>().text = "Player1 Gold :" + (int)gold;
    }
}
