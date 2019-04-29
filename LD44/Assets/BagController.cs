using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BagController : MonoBehaviour
{

    // Public variables we want to expose to the editor...
    public static float bag_weight = 0f;
    public static int monies = 0;
    public static int health = 40;
    public static bool alarm = false;
    public Text explainer_text;
    public static bool bag_weight_change = false;

    public GameObject lostMonies;
    public GameObject lostHearts;
    public bool alive = true;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   

        if (health > 0)
        {
            explainer_text.text = "You have " + monies + " monies, and your health is at " + health;
            alive = true;
        }
        else
        {
            explainer_text.text = "YOU DED, lol RIP...";
            alive = false;
        }

        

        if (alive == false)
        {
            // endgame
        }



    }

    private void updateHeft()
    {
        Move2D.speed = Move2D.speed - bag_weight;
        bag_weight_change = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Gaurd")
        {
            if ( monies > 0 )
            {
                monies = monies - 5;
                GameObject monies_ps = (GameObject)GameObject.Instantiate(lostMonies);
                monies_ps.transform.position = transform.position;
            } 
            else
            {
                health = health - 3;
                GameObject heart_ps = (GameObject)GameObject.Instantiate(lostHearts);
                heart_ps.transform.position = transform.position;
            }
        }
    }


}
