using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worldPeace : MonoBehaviour
{
    public Transform follow_me;
    public float cam_smooth = 0.5f;

    private Vector3 velocity = Vector3.zero;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = follow_me.TransformPoint(new Vector3(0, 0, -10));
        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, cam_smooth);
    }
}
