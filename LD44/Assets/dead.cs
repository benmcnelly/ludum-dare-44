﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dead : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        credits.endgame_info = "You escaped with " + BagController.monies + " monies!";
        
    }

    public void loadGame()
    {
        SceneManager.LoadScene("top-down", LoadSceneMode.Single);
    }

    public void endGame()
    {
        Application.Quit();
    }


}
