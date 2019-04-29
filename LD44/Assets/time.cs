using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class time : MonoBehaviour
{

    public Text self;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        DateTime theTime = DateTime.Now;
        string time = theTime.ToString("h:mm:ss");
        self.text = "Local Time: " + time;

    }
}
