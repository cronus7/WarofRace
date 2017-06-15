using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateU2 : MonoBehaviour
{
    // Use this for initialization
    int[] level = new int[] { 0, 0, 0 };
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Player2Bar1") != null)
        {
            CreateTopSoldier();
        }
        if (GameObject.Find("Player2Bar2") != null)
        {
            CreateMidSoldier();
        }
        if (GameObject.Find("Player2Bar3") != null)
        {
            CreateBotSoldier();
        }
    }

    void CreateKnight(float a, float b)
    {
        //load prefab to gameobject
        GameObject soldier = (GameObject)Instantiate(Resources.Load("prefabs/UKnight2"));
        //make it belongs to 'player2'
        GameObject mUIplay1 = GameObject.Find("player2");
        soldier.transform.parent = mUIplay1.transform;
        //set position
        soldier.transform.position = new Vector2(a, b);
    }
    void CreateAir(float a, float b)
    {
        GameObject soldier = (GameObject)Instantiate(Resources.Load("prefabs/UAir2"));
        //make it belongs to 'player2'
        GameObject mUIplay1 = GameObject.Find("player2");
        soldier.transform.parent = mUIplay1.transform;
        //set position 
        soldier.transform.position = new Vector2(a, b);
    }
    void CreateMagic(float a, float b)
    {
        GameObject soldier = (GameObject)Instantiate(Resources.Load("prefabs/UMagic2"));
        //make it belongs to 'player2'
        GameObject mUIplay1 = GameObject.Find("player2");
        soldier.transform.parent = mUIplay1.transform;
        //set position 
        soldier.transform.position = new Vector2(a, b);
    }
    void CreateArcher(float a, float b)
    {
        GameObject soldier = (GameObject)Instantiate(Resources.Load("prefabs/UArcher2"));
        //make it belongs to 'player2'
        GameObject mUIplay1 = GameObject.Find("player2");
        soldier.transform.parent = mUIplay1.transform;
        //set position
        soldier.transform.position = new Vector2(a, b);
    }

    //underworld player2

    void CreateTopSoldier()
    {
        // hold "8"
        //level  barrack up  "0"
        if(Input.GetKeyDown(KeyCode.Keypad0) && Input.GetKey(KeyCode.Keypad8))
        {
            if (level[0] <= 2)
            {
                if (GameObject.Find("P2Gold").GetComponent<GoldSystem2>().gold >= 1000)
                {
                    GameObject.Find("P2Gold").GetComponent<GoldSystem2>().gold -= 1000;
                    level[0]++;
                    GameObject.Find("Player2Bar1").GetComponent<Property>().health += 1500;
                    GameObject.Find("B1Hp2").GetComponent<B1Hp2>().lv += 1;
                }
            }

        }
        //arrows to create soldier 
        if (Input.GetKeyDown(KeyCode.UpArrow) && Input.GetKey(KeyCode.Keypad8))
        {
            if (GameObject.Find("P2Gold").GetComponent<GoldSystem2>().gold >= 220)
            {
                GameObject.Find("P2Gold").GetComponent<GoldSystem2>().gold -= 220;
                CreateKnight(23, -2);
            }

        }
        if (level[0] > 0)
        {
            if(Input.GetKeyDown(KeyCode.DownArrow) && Input.GetKey(KeyCode.Keypad8))
            {
                if (GameObject.Find("P2Gold").GetComponent<GoldSystem2>().gold >= 550)
                {
                    GameObject.Find("P2Gold").GetComponent<GoldSystem2>().gold -= 550;
                    CreateArcher(23, -2);
                }

            }
        }
        if (level[0] > 1)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow) && Input.GetKey(KeyCode.Keypad8))
            {
                if (GameObject.Find("P2Gold").GetComponent<GoldSystem2>().gold >= 800)
                {
                    GameObject.Find("P2Gold").GetComponent<GoldSystem2>().gold -= 800;
                    CreateMagic(23, -2);
                }

            }
        }
        if (level[0] > 2)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow) && Input.GetKey(KeyCode.Keypad8))
            {
                if (GameObject.Find("P2Gold").GetComponent<GoldSystem2>().gold >= 700)
                {
                    GameObject.Find("P2Gold").GetComponent<GoldSystem2>().gold -= 700;
                    CreateAir(23, -2);
                }

            }
        }
    }

    void CreateMidSoldier()
    {
        //hold "5"
        //level  barrack up  "0"
        if (Input.GetKeyDown(KeyCode.Keypad0) && Input.GetKey(KeyCode.Keypad5))
        {
            if (level[1] <= 2)
            {
                if (GameObject.Find("P2Gold").GetComponent<GoldSystem2>().gold >= 1000)
                {
                    GameObject.Find("P2Gold").GetComponent<GoldSystem2>().gold -= 1000;
                    level[1]++;
                    GameObject.Find("Player2Bar2").GetComponent<Property>().health += 1500;
                    GameObject.Find("B2Hp2").GetComponent<B2Hp2>().lv += 1;
                }
            }

        }
        //arrows to create soldier 
        if (Input.GetKeyDown(KeyCode.UpArrow) && Input.GetKey(KeyCode.Keypad5))
        {
            if (GameObject.Find("P2Gold").GetComponent<GoldSystem2>().gold >= 220)
            {
                GameObject.Find("P2Gold").GetComponent<GoldSystem2>().gold -= 220;
                CreateKnight(23, -10);
            }

        }
        if (level[1] > 0)
        {
            if (Input.GetKeyDown(KeyCode.DownArrow) && Input.GetKey(KeyCode.Keypad5))
            {
                if (GameObject.Find("P2Gold").GetComponent<GoldSystem2>().gold >= 550)
                {
                    GameObject.Find("P2Gold").GetComponent<GoldSystem2>().gold -= 550;
                    CreateArcher(23, -10);
                }

            }
        }
        if (level[1] > 1)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow) && Input.GetKey(KeyCode.Keypad5))
            {
                if (GameObject.Find("P2Gold").GetComponent<GoldSystem2>().gold >= 800)
                {
                    GameObject.Find("P2Gold").GetComponent<GoldSystem2>().gold -= 800;
                    CreateMagic(23, -10);
                }

            }
        }
        if (level[1] > 2)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow) && Input.GetKey(KeyCode.Keypad5))
            {
                if (GameObject.Find("P2Gold").GetComponent<GoldSystem2>().gold >= 700)
                {
                    GameObject.Find("P2Gold").GetComponent<GoldSystem2>().gold -= 700;
                    CreateAir(23, -10);
                }

            }
        }
    }
    void CreateBotSoldier()
    {
        //hold "2"
        //level  barrack up  "0"
        if (Input.GetKeyDown(KeyCode.Keypad0) && Input.GetKey(KeyCode.Keypad2))
        {
            if (level[2] <= 2)
            {
                if (GameObject.Find("P2Gold").GetComponent<GoldSystem2>().gold >= 1000)
                {
                    GameObject.Find("P2Gold").GetComponent<GoldSystem2>().gold -= 1000;
                    level[2]++;
                    GameObject.Find("Player2Bar3").GetComponent<Property>().health += 1500;
                    GameObject.Find("B3Hp2").GetComponent<B3Hp2>().lv += 1;
                }
            }

        }
        //arrows to create soldier 
        if (Input.GetKeyDown(KeyCode.UpArrow) && Input.GetKey(KeyCode.Keypad2))
        {
            if (GameObject.Find("P2Gold").GetComponent<GoldSystem2>().gold >= 220)
            {
                GameObject.Find("P2Gold").GetComponent<GoldSystem2>().gold -= 220;
                CreateKnight(23, -18);
            }

        }
        if (level[2] > 0)
        {
            if (Input.GetKeyDown(KeyCode.DownArrow) && Input.GetKey(KeyCode.Keypad2))
            {
                if (GameObject.Find("P2Gold").GetComponent<GoldSystem2>().gold >= 550)
                {
                    GameObject.Find("P2Gold").GetComponent<GoldSystem2>().gold -= 550;
                    CreateArcher(23, -18);
                }

            }
        }
        if (level[2] > 1)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow) && Input.GetKey(KeyCode.Keypad2))
            {
                if (GameObject.Find("P2Gold").GetComponent<GoldSystem2>().gold >= 800)
                {
                    GameObject.Find("P2Gold").GetComponent<GoldSystem2>().gold -= 800;
                    CreateMagic(23, -18);
                }

            }
        }
        if (level[2] > 2)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow) && Input.GetKey(KeyCode.Keypad2))
            {
                if (GameObject.Find("P2Gold").GetComponent<GoldSystem2>().gold >= 700)
                {
                    GameObject.Find("P2Gold").GetComponent<GoldSystem2>().gold -= 700;
                    CreateAir(23, -18);
                }

            }
        }
    }
}