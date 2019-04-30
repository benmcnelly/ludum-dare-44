using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class extractController : MonoBehaviour
{
    Collider2D m_Collider;

    // Start is called before the first frame update
    void Start()
    {
        m_Collider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if ( BagController.monies > 25 )
        {
            this.GetComponent<Renderer>().enabled = true;
            m_Collider.enabled = m_Collider.enabled = true;
        }
        else
        {
            this.GetComponent<Renderer>().enabled = false;
            m_Collider.enabled = m_Collider.enabled = false;
        }
        
    }
}
