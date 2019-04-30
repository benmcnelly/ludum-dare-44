using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endgame : MonoBehaviour
{
    public GameObject endgamebutton;
    public static bool can_quit = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (can_quit == true)
        {
            endgamebutton.SetActive(true);
        }
        else
        {
            endgamebutton.SetActive(false);
        }
    }
}
