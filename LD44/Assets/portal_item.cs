﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal_item : MonoBehaviour
{

    public GameObject target_portal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("OnCollisionEnter2D");

        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.transform.position = target_portal.transform.position;
        }
    }
}
