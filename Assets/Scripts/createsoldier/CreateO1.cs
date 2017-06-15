using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateO1 : MonoBehaviour {
    // Use this for initialization
    int[] level = new int[] { 0, 0, 0 };
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Player1Bar1")!= null)
        {
            CreateTopSoldier();
        }
        if (GameObject.Find("Player1Bar2") != null)
        {
            CreateMidSoldier();
        }
        if (GameObject.Find("Player1Bar3") != null)
        {
            CreateBotSoldier();
        }
    }

    void CreateKnight(float a, float b)
    {
        //load prefab to gameobject
        GameObject soldier = (GameObject)Instantiate(Resources.Load("prefabs/OKnight1"));
        //make it belongs to 'player1'
        GameObject mUIplay1 = GameObject.Find("player1");
        soldier.transform.parent = mUIplay1.transform;
        //set position
        soldier.transform.position = new Vector2(a, b);
    }
    void CreateAir(float a, float b)
    {
        GameObject soldier = (GameObject)Instantiate(Resources.Load("prefabs/OAir1"));
        //make it belongs to 'player1'
        GameObject mUIplay1 = GameObject.Find("player1");
        soldier.transform.parent = mUIplay1.transform;
        //set position 
        soldier.transform.position = new Vector2(a, b);
    }
    void CreateMagic(float a, float b)
    {
        GameObject soldier = (GameObject)Instantiate(Resources.Load("prefabs/OMagic1"));
        //make it belongs to 'player1'
        GameObject mUIplay1 = GameObject.Find("player1");
        soldier.transform.parent = mUIplay1.transform;
        //set position 
        soldier.transform.position = new Vector2(a, b);
    }
    void CreateArcher(float a, float b)
    {
        GameObject soldier = (GameObject)Instantiate(Resources.Load("prefabs/OArcher1"));
        //make it belongs to 'player1'
        GameObject mUIplay1 = GameObject.Find("player1");
        soldier.transform.parent = mUIplay1.transform;
        //set position
        soldier.transform.position = new Vector2(a, b);
    }

    //tempular player1

    void CreateTopSoldier()
    {
        //hold "q"
        //level barrack up  "g"
        if ((Input.GetKeyDown(KeyCode.G)) && (Input.GetKey(KeyCode.Q)))
        {
            if (level[0] <= 2)
            {
                if (GameObject.Find("P1Gold").GetComponent<GoldSystem1>().gold >= 1000)
                {
                    GameObject.Find("P1Gold").GetComponent<GoldSystem1>().gold -= 1000;
                    level[0]++;
                    GameObject.Find("Player1Bar1").GetComponent<Property>().health += 1500;
                    GameObject.Find("B1Hp1").GetComponent<B1Hp1>().lv += 1;
                }
            }

        }
        //h,j,k,l to create soldier
        if ((Input.GetKeyDown(KeyCode.H)) && (Input.GetKey(KeyCode.Q)))
        {
            if (GameObject.Find("P1Gold").GetComponent<GoldSystem1>().gold >= 220)
            {
                GameObject.Find("P1Gold").GetComponent<GoldSystem1>().gold -= 220;
                CreateKnight(-5, -2);
            }

        }
        if (level[0] > 0)
        {
            if ((Input.GetKeyDown(KeyCode.J)) && (Input.GetKey(KeyCode.Q)))
            {
                if (GameObject.Find("P1Gold").GetComponent<GoldSystem1>().gold >= 550)
                {
                    GameObject.Find("P1Gold").GetComponent<GoldSystem1>().gold -= 550;
                    CreateArcher(-5, -2);
                }

            }
        }
        if (level[0] > 1)
        {
            if ((Input.GetKeyDown(KeyCode.K)) && (Input.GetKey(KeyCode.Q)))
            {
                if (GameObject.Find("P1Gold").GetComponent<GoldSystem1>().gold >= 800)
                {
                    GameObject.Find("P1Gold").GetComponent<GoldSystem1>().gold -= 800;
                    CreateMagic(-5, -2);
                }

            }
        }
        if (level[0] > 2)
        {
            if (Input.GetKeyDown(KeyCode.L) && (Input.GetKey(KeyCode.Q)))
            {
                if (GameObject.Find("P1Gold").GetComponent<GoldSystem1>().gold >= 700)
                {
                    GameObject.Find("P1Gold").GetComponent<GoldSystem1>().gold -= 700;
                    CreateAir(-5, -2);
                }

            }
        }
    }

    void CreateMidSoldier()
    {
        //hold "a"
        //level  barrack up  "g"
        if ((Input.GetKeyDown(KeyCode.G)) && (Input.GetKey(KeyCode.A)))
        {
            if (level[1] <= 2)
            {
                if (GameObject.Find("P1Gold").GetComponent<GoldSystem1>().gold >= 1000)
                {
                    GameObject.Find("P1Gold").GetComponent<GoldSystem1>().gold -= 1000;
                    level[1]++;
                    GameObject.Find("Player1Bar2").GetComponent<Property>().health += 1500;
                    GameObject.Find("B2Hp1").GetComponent<B2Hp1>().lv += 1;
                }
            }

        }
        //h,j,k,l to create soldier
        if ((Input.GetKeyDown(KeyCode.H)) && (Input.GetKey(KeyCode.A)))
        {
            if (GameObject.Find("P1Gold").GetComponent<GoldSystem1>().gold >= 220)
            {
                GameObject.Find("P1Gold").GetComponent<GoldSystem1>().gold -= 220;
                CreateKnight(-5, -10);
            }

        }
        if (level[1] > 0)
        {
            if ((Input.GetKeyDown(KeyCode.J)) && (Input.GetKey(KeyCode.A)))
            {
                if (GameObject.Find("P1Gold").GetComponent<GoldSystem1>().gold >= 550)
                {
                    GameObject.Find("P1Gold").GetComponent<GoldSystem1>().gold -= 550;
                    CreateArcher(-5, -10);
                }

            }
        }
        if (level[1] > 1)
        {
            if ((Input.GetKeyDown(KeyCode.K)) && (Input.GetKey(KeyCode.A)))
            {
                if (GameObject.Find("P1Gold").GetComponent<GoldSystem1>().gold >= 800)
                {
                    GameObject.Find("P1Gold").GetComponent<GoldSystem1>().gold -= 800;
                    CreateMagic(-5, -10);
                }

            }
        }
        if (level[1] > 2)
        {
            if (Input.GetKeyDown(KeyCode.L) && (Input.GetKey(KeyCode.A)))
            {
                if (GameObject.Find("P1Gold").GetComponent<GoldSystem1>().gold >= 700)
                {
                    GameObject.Find("P1Gold").GetComponent<GoldSystem1>().gold -= 700;
                    CreateAir(-5, -10);
                }

            }
        }
    }
    void CreateBotSoldier()
    {
        //hold "z"
        //level  barrack up  "g"
        if ((Input.GetKeyDown(KeyCode.G)) && (Input.GetKey(KeyCode.Z)))
        {
            if (level[2] <= 2)
            {
                if (GameObject.Find("P1Gold").GetComponent<GoldSystem1>().gold >= 1000)
                {
                    GameObject.Find("P1Gold").GetComponent<GoldSystem1>().gold -= 1000;
                    level[2]++;
                    GameObject.Find("Player1Bar3").GetComponent<Property>().health += 1500;
                    GameObject.Find("B3Hp1").GetComponent<B3Hp1>().lv += 1;
                }
            }

        }
        //h,j,k,l to create soldier 
        if ((Input.GetKeyDown(KeyCode.H)) && (Input.GetKey(KeyCode.Z)))
        {
            if (GameObject.Find("P1Gold").GetComponent<GoldSystem1>().gold >= 220)
            {
                GameObject.Find("P1Gold").GetComponent<GoldSystem1>().gold -= 220;
                CreateKnight(-5, -18);
            }

        }
        if (level[2] > 0)
        {
            if ((Input.GetKeyDown(KeyCode.J)) && (Input.GetKey(KeyCode.Z)))
            {
                if (GameObject.Find("P1Gold").GetComponent<GoldSystem1>().gold >= 550)
                {
                    GameObject.Find("P1Gold").GetComponent<GoldSystem1>().gold -= 550;
                    CreateArcher(-5, -18);
                }

            }
        }
        if (level[2] > 1)
        {
            if ((Input.GetKeyDown(KeyCode.K)) && (Input.GetKey(KeyCode.Z)))
            {
                if (GameObject.Find("P1Gold").GetComponent<GoldSystem1>().gold >= 800)
                {
                    GameObject.Find("P1Gold").GetComponent<GoldSystem1>().gold -= 800;
                    CreateMagic(-5, -18);
                }

            }
        }
        if (level[2] > 2)
        {
            if (Input.GetKeyDown(KeyCode.L) && (Input.GetKey(KeyCode.Z)))
            {
                if (GameObject.Find("P1Gold").GetComponent<GoldSystem1>().gold >= 700)
                {
                    GameObject.Find("P1Gold").GetComponent<GoldSystem1>().gold -= 700;
                    CreateAir(-5, -18);
                }

            }
        }
    }
}
