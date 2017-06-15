using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createSoldier : Property
{
    // Use this for initialization
    int[] level = new int[]{0, 0, 0, 0, 0, 0}; 
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        CreateTopSoldier1();
        CreateMidSoldier1();
        CreateButSoldier1();
        CreateButSoldier2();

    }

    void CreateTNight1(float a, float b)
    {
        //load prefab to gameobject
        GameObject soldier = (GameObject)Instantiate(Resources.Load("prefabs/TKnight1"));
        //make it belongs to 'player1'
        GameObject mUIplay1 = GameObject.Find("player1");
        soldier.transform.parent = mUIplay1.transform;
        //set position
        soldier.transform.position = new Vector2(a, b);
    }
    void CreateTAir1(float a, float b)
    {
        GameObject soldier = (GameObject)Instantiate(Resources.Load("prefabs/TAir1"));
        //make it belongs to 'player1'
        GameObject mUIplay1 = GameObject.Find("player1");
        soldier.transform.parent = mUIplay1.transform;
        //set position 
        soldier.transform.position = new Vector2(a, b);
    }
    void CreateTMagic1(float a, float b)
    {
        GameObject soldier = (GameObject)Instantiate(Resources.Load("prefabs/TMagic1"));
        //make it belongs to 'player1'
        GameObject mUIplay1 = GameObject.Find("player1");
        soldier.transform.parent = mUIplay1.transform;
        //set position 
        soldier.transform.position = new Vector2(a, b);
    }
    void CreateTArcher1(float a, float b)
    {
        GameObject soldier = (GameObject)Instantiate(Resources.Load("prefabs/TArcher1"));
        //make it belongs to 'player1'
        GameObject mUIplay1 = GameObject.Find("player1");
        soldier.transform.parent = mUIplay1.transform;
        //set position
        soldier.transform.position = new Vector2(a, b);
    }

    void CreateTKnight2(float a, float b)
    {
        GameObject soldier = (GameObject)Instantiate(Resources.Load("prefabs/TKnight2"));
        //make it belongs to 'player2'
        GameObject mUIplay1 = GameObject.Find("player2");
        soldier.transform.parent = mUIplay1.transform;
        //set position
        soldier.transform.position = new Vector2(a, b);
    }
    void CreateTArcher2(float a, float b)
    {
        GameObject soldier = (GameObject)Instantiate(Resources.Load("prefabs/TArcher2"));
        //make it belongs to 'player2'
        GameObject mUIplay1 = GameObject.Find("player2");
        soldier.transform.parent = mUIplay1.transform;
        //set position
        soldier.transform.position = new Vector2(a, b);
    }
    void CreateTAir2(float a, float b)
    {
        GameObject soldier = (GameObject)Instantiate(Resources.Load("prefabs/TAir2"));
        //make it belongs to 'player2'
        GameObject mUIplay1 = GameObject.Find("player2");
        soldier.transform.parent = mUIplay1.transform;
        //set position
        soldier.transform.position = new Vector2(a, b);
    }
    void CreateTMagic2(float a, float b)
    {
        GameObject soldier = (GameObject)Instantiate(Resources.Load("prefabs/TMagic2"));
        //make it belongs to 'player2'
        GameObject mUIplay1 = GameObject.Find("player2");
        soldier.transform.parent = mUIplay1.transform;
        //set position
        soldier.transform.position = new Vector2(a, b);
    }

    //tempular player1

    void CreateTopSoldier1()
    {
        //level top barrack up  "q"
        if ((Input.GetKeyDown(KeyCode.Q))&& (Input.GetKey(KeyCode.W)))
        {
            level[0]++;
        }
        //w,e,r,t to create soldier in top
        if ((Input.GetKeyDown(KeyCode.Z)) && (Input.GetKey(KeyCode.W)))
        {
            CreateTNight1(-5, -1);
        }
        if (level[0] > 0)
        {
            if ((Input.GetKeyDown(KeyCode.X)) && (Input.GetKey(KeyCode.W)))
            {
                CreateTArcher1(-5, -1);
            }
        }
        if (level[0] > 1)
        {
            if ((Input.GetKeyDown(KeyCode.C)) && (Input.GetKey(KeyCode.W)))
            {
                CreateTMagic1(-5, -1);
            }
        }
        if (level[0] > 2)
        {
            if (Input.GetKeyDown(KeyCode.V) && (Input.GetKey(KeyCode.W)))
            {
                CreateTAir1(-5, -1);
            }
        }
    }

    void CreateMidSoldier1()
    {
        //level top barrack up  "a"
        if (Input.GetKeyDown(KeyCode.Q) && (Input.GetKey(KeyCode.D)))
        {
            level[1]++;
        }
        //s,d,f,g to create soldier in top
        if (Input.GetKeyDown(KeyCode.Z) && (Input.GetKey(KeyCode.D)))
        {
            CreateTNight1(-5, -8);
        }
        if (level[1] > 0)
        {
            if (Input.GetKeyDown(KeyCode.X) && (Input.GetKey(KeyCode.D)))
            {
                CreateTArcher1(-5, -8);
            }
        }
        if (level[1] > 1)
        {
            if (Input.GetKeyDown(KeyCode.C) && (Input.GetKey(KeyCode.D)))
            {
                CreateTMagic1(-5, -8);
            }
        }
        if (level[1] > 2)
        {
            if (Input.GetKeyDown(KeyCode.V) && (Input.GetKey(KeyCode.D)))
            {
                CreateTAir1(-5, -8);
            }
        }
    }
    void CreateButSoldier1()
    {
        //level top barrack up  "z"
        if (Input.GetKeyDown(KeyCode.Q) && (Input.GetKey(KeyCode.S)))
        {
            level[2]++;
        }
        //x,c,v,b to create soldier in top
        if (Input.GetKeyDown(KeyCode.Z) && (Input.GetKey(KeyCode.S)))
        {
            CreateTNight1(-5, -16);
        }
        if (level[2] > 0)
        {
            if (Input.GetKeyDown(KeyCode.X) && (Input.GetKey(KeyCode.S)))
            {
                CreateTArcher1(-5, -16);
            }
        }
        if (level[2] > 1)
        {
            if (Input.GetKeyDown(KeyCode.C) && (Input.GetKey(KeyCode.S)))
            {
                CreateTMagic1(-5, -16);
            }
        }
        if (level[2] > 2)
        {
            if (Input.GetKeyDown(KeyCode.V) && (Input.GetKey(KeyCode.S)))
            {
                CreateTAir1(-5, -16);
            }
        }
    }


    //Tempular player2

    void CreateButSoldier2()
    {
        //level top barrack up  "z"
        if (Input.GetKey(KeyCode.DownArrow) && Input.GetKeyDown(KeyCode.Keypad5))
        {
            level[3]++;
        }
        //x,c,v,b to create soldier in top
        if (Input.GetKey(KeyCode.DownArrow) && Input.GetKeyDown(KeyCode.Keypad1))
        {
            CreateTKnight2(23, -16);
        }
        if (level[3] > 0)
        {
            if (Input.GetKey(KeyCode.DownArrow) && Input.GetKeyDown(KeyCode.Keypad2))
            {
                CreateTArcher2(23, -16);
            }
        }
        if (level[3] > 1)
        {
            if (Input.GetKey(KeyCode.DownArrow) && Input.GetKeyDown(KeyCode.Keypad3))
            {
                CreateTMagic2(23, -16);
            }
        }
        if (level[3] > 2)
        {
            if (Input.GetKey(KeyCode.DownArrow) && Input.GetKeyDown(KeyCode.Keypad4))
            {
                CreateTAir2(23, -16);
            }
        }
    }
}
