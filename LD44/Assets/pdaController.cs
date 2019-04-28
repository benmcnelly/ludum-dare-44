using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pdaController : MonoBehaviour
{
    public Text self;
    public static string pda_update;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        self.text = pda_update;
    }
}
