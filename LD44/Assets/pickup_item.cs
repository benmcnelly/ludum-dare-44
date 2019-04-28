using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickup_item : MonoBehaviour
{
    // Editor variables
    public int worth = 1;
    public int heft = 1;
    public bool allarmed = false;
    public Text gui_text;

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
            Debug.Log("I can detect player!");
        }
    }
}
