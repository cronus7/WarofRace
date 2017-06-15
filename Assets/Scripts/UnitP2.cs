using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UnitP2 : MonoBehaviour
{

    private List<Transform> targets;
    private Transform closeTarget;
    private Transform myTransform;
    private float speed;
    private int atk;
    private float atkrange;
    private int type;
    private float atkwaittime;
    float currentime = 99999f;

    // Use this for initialization
    void Start()
    {

        Property m_soldier = gameObject.GetComponent<Property>();
        speed = m_soldier.speed;
        atk = m_soldier.attack;
        atkrange = m_soldier.range;
        type = m_soldier.type;
        atkwaittime = m_soldier.attackspeed;
        targets = new List<Transform>();
        closeTarget = null;
        myTransform = transform;
        search();
        SortTargetByDistance();
        Time.timeScale = 0.2f;

    }
    // Update is called once per frame
    void FixedUpdate()
    {

        if (type == 0)
        {

            meelee();
        }
        if (type == 1)
        {

            ranged();
        }
        if (type == 2)
        {
            mage();
        }
        if (type == 3)
        {
            air();
        }

    }


    void meelee()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        targets = new List<Transform>();
        search();
        MeeleeSearch();

    }
    void ranged()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        targets = new List<Transform>();
        search();
        RangedSearch();

    }
    void mage()
    {

        MageAttack();
    }

    void air()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        targets = new List<Transform>();
        search();
        AirSearch();
    }
    void search()
    {
        GameObject[] go = GameObject.FindGameObjectsWithTag("Player1");
        foreach (GameObject gm in go)
        {
            AddTarget(gm.transform);
        }
    }
    public void AddTarget(Transform ts)
    {
        targets.Add(ts);
    }

    private void SortTargetByDistance() //sort targets by distance
    {

        targets.Sort
         (delegate (Transform t1, Transform t2)
         {

             return Vector2.Distance(t1.position, myTransform.position).CompareTo(Vector2.Distance(t2.position, myTransform.position));


         }
         );


    }
    private void MeeleeSearch()
    {
        SortTargetByDistance();
        closeTarget = targets[0];
        Property enemy = closeTarget.gameObject.GetComponent<Property>();
        if (enemy.type != 3 && enemy.type != 4)
        {
            if (Vector2.Distance(transform.position, closeTarget.position) <= atkrange)
            {
                if (enemy.type == 6)
                {
                    speed = 0;
                    GetComponent<Animator>().SetBool("att", true);
                    if (currentime < atkwaittime)
                    {

                        currentime += Time.deltaTime;
                    }
                    else
                    {
                        GameObject.Find("Player1Core(Clone)").GetComponent<Property>().health -= atk;
                        currentime = 0;

                    }
                }
                else
                {
                    speed = 0;
                    GetComponent<Animator>().SetBool("att", true);
                    if (currentime < atkwaittime)
                    {

                        currentime += Time.deltaTime;
                    }
                    else
                    {
                        enemy.health = enemy.health - atk;
                        currentime = 0;

                    }
                    if (enemy.health <= 0)
                    {
                        Destroy(enemy.gameObject);
                        GameObject.Find("P2Gold").GetComponent<GoldSystem2>().gold += enemy.reward;

                    }
                }
            }
            else
            {
                GetComponent<Animator>().SetBool("att", false);
                Property m_soldier = gameObject.GetComponent<Property>();
                speed = m_soldier.speed;

            }
        }
    }



    private void RangedSearch()
    {
        SortTargetByDistance();
        closeTarget = targets[0];
        Property enemy = closeTarget.gameObject.GetComponent<Property>();
        if (Vector2.Distance(transform.position, closeTarget.position) <= atkrange)
        {
            if (enemy.type == 6)
            {
                speed = 0;
                GetComponent<Animator>().SetBool("att", true);
                if (currentime < atkwaittime)
                {

                    currentime += Time.deltaTime;
                }
                else
                {
                    GameObject.Find("Player1Core(Clone)").GetComponent<Property>().health -= atk;
                    currentime = 0;

                }
            }
            else
            {
                speed = 0;
                GetComponent<Animator>().SetBool("att", true);
                if (enemy.type == 3)
                {
                    if (currentime < atkwaittime)
                    {

                        currentime += Time.deltaTime;
                    }
                    else
                    {
                        enemy.health = enemy.health - atk;
                        currentime = 0;

                    }

                }
                else if (enemy.type != 4)
                {
                    if (currentime < atkwaittime)
                    {

                        currentime += Time.deltaTime;
                    }
                    else
                    {
                        enemy.health = enemy.health - atk;
                        currentime = 0;

                    }
                }
            }


            if (enemy.health <= 0)
            {
                Destroy(enemy.gameObject);
                GameObject.Find("P2Gold").GetComponent<GoldSystem2>().gold += enemy.reward;
            }

        }
        else
        {
            GetComponent<Animator>().SetBool("att", false);
            Property m_soldier = gameObject.GetComponent<Property>();
            speed = m_soldier.speed;
        }
    }

    public void AirSearch()
    {
        SortTargetByDistance();
        closeTarget = targets[0];
        Property enemy = closeTarget.gameObject.GetComponent<Property>();
        if (enemy.type == 5 || enemy.type == 6 || enemy.type == 2)
        {
            if (Vector2.Distance(transform.position, closeTarget.position) <= atkrange)
            {
                if (enemy.type == 6)
                {
                    speed = 0;
                    GetComponent<Animator>().SetBool("att", true);
                    if (currentime < atkwaittime)
                    {

                        currentime += Time.deltaTime;
                    }
                    else
                    {
                        GameObject.Find("Player1Core(Clone)").GetComponent<Property>().health -= atk;
                        currentime = 0;

                    }
                }
                else
                {
                    speed = 0;
                    GetComponent<Animator>().SetBool("att", true);
                    if (currentime < atkwaittime)
                    {

                        currentime += Time.deltaTime;
                    }
                    else
                    {
                        enemy.health = enemy.health - atk;
                        currentime = 0;

                    }
                }

                if (enemy.health <= 0 && enemy.type != 6)
                {
                    Destroy(enemy.gameObject);
                    GameObject.Find("P2Gold").GetComponent<GoldSystem2>().gold += enemy.reward;

                }
            }
            else
            {
                GetComponent<Animator>().SetBool("att", false);
                Property m_soldier = gameObject.GetComponent<Property>();
                speed = m_soldier.speed;
            }

        }

    }
    void MageAttack()
    {
        if (currentime < atkwaittime)
        {

            currentime += Time.deltaTime;
        }
        else
        {
            CreateMagic(transform.position);
            currentime = 0;

        }

    }
    void CreateMagic(Vector2 gg)
    {

        GameObject atk = (GameObject)Instantiate(Resources.Load("prefabs/tornado2"));
        atk.transform.position = gg;
        //Debug.Log(atk.transform.position);
    }
}