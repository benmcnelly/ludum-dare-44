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



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   
        explainer_text.text = "You have " + monies + " monies, and your health is at " + health + " and your bag is making your speed " + Move2D.speed + " of 10";

        if (bag_weight_change == true)
        {
            updateHeft();
        }



    }

    private void updateHeft()
    {
        Move2D.speed = Move2D.speed - bag_weight;
        bag_weight_change = false;
    }

}
