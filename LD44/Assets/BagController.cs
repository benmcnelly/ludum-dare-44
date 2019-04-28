using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BagController : MonoBehaviour
{

    // Public variables we want to expose to the editor...
    public static int bag_weight = 0;
    public static int monies = 0;
    public static int health = 40;
    public static bool alarm = false;
    public Text explainer_text;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        explainer_text.text = "You have " + monies + " monies, and your health is at " + health + " and your bag is like " + bag_weight + " pounds..";
    }


    public static void updateStatus()
    {

    }

}
