using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup_item : MonoBehaviour
{
    // Editor variables
    public int worth = 1;
    public int heft = 1;
    public bool allarmed = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("bam");

        if (collision.otherCollider.gameObject.tag == "Player")
        {
            Debug.Log("playerhitme");
        }
    }
}
