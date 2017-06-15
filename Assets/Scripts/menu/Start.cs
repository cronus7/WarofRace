using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Start : MonoBehaviour {
    
    //set player1 as tempular
    public void SetRace1as1()
    {
        var a = GameObject.Find("Canvas").GetComponent<race>();
        a.race1 = 1;
        GameObject.Find("RaceOfPlayer1").GetComponent<Text>().text = "Templar";
        GameObject obj = (GameObject)Resources.Load("prefabs/Player1Core");
        obj.GetComponent<CreateT1>().enabled = true;
        obj.GetComponent<CreateO1>().enabled = false;
        obj.GetComponent<CreateU1>().enabled = false;

    }
    //set player1 as orc
    public void SetRace1as2()
    {
        var a = GameObject.Find("Canvas").GetComponent<race>();
        a.race1 = 2;
        GameObject.Find("RaceOfPlayer1").GetComponent<Text>().text = "Orc";
        GameObject obj = (GameObject)Resources.Load("prefabs/Player1Core");
        obj.GetComponent<CreateT1>().enabled = false;
        obj.GetComponent<CreateO1>().enabled = true;
        obj.GetComponent<CreateU1>().enabled = false;
    }
    //set player1 as underworld
    public void SetRace1as3()
    {
        var a = GameObject.Find("Canvas").GetComponent<race>();
        a.race1 = 3;
        GameObject.Find("RaceOfPlayer1").GetComponent<Text>().text = "UnderWorld";
        GameObject obj = (GameObject)Resources.Load("prefabs/Player1Core");
        obj.GetComponent<CreateT1>().enabled = false;
        obj.GetComponent<CreateO1>().enabled = false;
        obj.GetComponent<CreateU1>().enabled = true;
    }
    //set player2 as tempular
    public void SetRace2as1()
    {
        var a = GameObject.Find("Canvas").GetComponent<race>();
        a.race2 = 1;
        GameObject.Find("RaceOfPlayer2").GetComponent<Text>().text = "Templar";
        GameObject obj = (GameObject)Resources.Load("prefabs/Player2Core");
        obj.GetComponent<CreateT2>().enabled = true;
        obj.GetComponent<CreateO2>().enabled = false;
        obj.GetComponent<CreateU2>().enabled = false;
    }
    //set player2 as orc
    public void SetRace2as2()
    {
        var a = GameObject.Find("Canvas").GetComponent<race>();
        a.race2 = 2;
        GameObject.Find("RaceOfPlayer2").GetComponent<Text>().text = "Orc";
        GameObject obj = (GameObject)Resources.Load("prefabs/Player2Core");
        obj.GetComponent<CreateT2>().enabled = false;
        obj.GetComponent<CreateO2>().enabled = true;
        obj.GetComponent<CreateU2>().enabled = false;
    }
    //set player2 as underworld
    public void SetRace2as3()
    {
        var a = GameObject.Find("Canvas").GetComponent<race>();
        a.race2 = 3;
        GameObject.Find("RaceOfPlayer2").GetComponent<Text>().text = "UnderWorld";
        GameObject obj = (GameObject)Resources.Load("prefabs/Player2Core");
        obj.GetComponent<CreateT2>().enabled = false;
        obj.GetComponent<CreateO2>().enabled = false;
        obj.GetComponent<CreateU2>().enabled = true;

    }
}
