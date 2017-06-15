using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackeffect : MonoBehaviour {

    //float attackspeed = 1;//attack move speed
    private float speed;    

    
    // Use this for initialization
    void Start()
    {
        Property arrow = gameObject.GetComponent<Property>();
        speed = arrow.speed;
        //Time.timeScale = 0.2f;
    }

    // Update is called once per frame
    void Update()
    {
        Property magic = gameObject.GetComponent<Property>();
        if (magic.teamNumber == 1)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

    }
    void OnTriggerEnter2D(Collider2D co)
    {
        Property collided = co.gameObject.GetComponent<Property>();
        Property atk = gameObject.GetComponent<Property>();
        if (collided.type != 3 && collided.type !=5 && collided.type !=6)
        {
            if (collided.teamNumber != atk.teamNumber)
            {
                collided.health -= atk.attack;
                if (collided.health <= 0)
                {
                    Destroy(collided.gameObject);
                    if (collided.teamNumber == 2)
                    {
                        GameObject.Find("P1Gold").GetComponent<GoldSystem1>().gold += collided.reward;
                    }
                    else
                    {
                        GameObject.Find("P2Gold").GetComponent<GoldSystem2>().gold += collided.reward;
                    }
                    
                }
            }
       }
       
        // Destroy(gameObject);
    }
}

