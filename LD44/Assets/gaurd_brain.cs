using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gaurd_brain : MonoBehaviour
{

    // movement vars
    public float gaurd_speed = 3f;
    public Transform target = null;

    // states
    public bool im_allarmed = true;
    public bool im_patrolling = false;
    public bool im_atmypost = false;

    public Transform post_one;
    public Transform post_two;

    // testing 
    public bool isEmpty;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        isEmpty = true;
    }


    // Update is called once per frame
    void Update()
    {
        // check global alarm
        if (BagController.alarm == true)
        {
            im_allarmed = true;
        }
    
        if (im_allarmed == true)
        {
            if (target == null)
            {
                // play audio, someone triggered the alarm, find them!

            }
            else
            {
                if (isEmpty == true)
                {
                    target = null;
                }
                else
                {
                    var thief = target.transform;
                    transform.LookAt(thief.position);
                    transform.Rotate(new Vector3(0, -90, 0), Space.Self);
                    transform.Translate(new Vector3(gaurd_speed * Time.deltaTime, 0, 0));
                }

            }


        } else
        {
            patrolCheck();
        }


    }


    void OnTriggerStay2D(Collider2D collision)
    {

        isEmpty = false;

        if (collision.gameObject.tag == "Player")
        {
            target = collision.gameObject.transform;
        }
        else
        {
            target = null;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            target = null;
            // play audio, where did he go?
        }
    }

    void patrolCheck()
    {
        if (im_atmypost == true)
        {
            //
        } else
        {
            im_patrolling = true;
            patrolControl();
        }
    }

    void patrolControl()
    {
        if (im_atmypost == true )
        {
            // check which post, send gaurd to other post
        } else
        {
            // not at either post somehow? Go to the first one then and toggle im_atmypost to true
        }
    }


}
