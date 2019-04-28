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
    public string about_text;
    private object newtext;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D (Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
           
            if (Input.GetKeyDown(KeyCode.E))
            {
                BagController.bag_weight += heft;
                BagController.monies += worth;
                if (allarmed == true)
                {
                    BagController.alarm = true;
                }
                // oh and delete this...
                Destroy(this.gameObject);
            }

        }
    }
}
