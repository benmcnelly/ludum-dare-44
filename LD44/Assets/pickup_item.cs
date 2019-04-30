using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickup_item : MonoBehaviour
{
    // Editor variables
    public int worth = 1;
    public float heft = 1f;
    public bool allarmed = false;
    public string about_text;
    public Texture preview_image;
    public AudioSource audioSource;

    private object newtext;
    private bool taken = false;

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
            pdaController.pda_update = about_text;
            if (preview_image != null)
            {
                pda_previewImage.load_texture = preview_image;
            } else
            {
                pda_previewImage.load_texture = null;
            }
            

            if (Input.GetKeyDown(KeyCode.E))
            {
                BagController.bag_weight += heft;
                BagController.monies += worth;
                BagController.bag_weight_change = true;
                if (allarmed == true)
                {
                    BagController.alarm = true;
                }
                // oh and delete this...
                pdaController.pda_update = "YOINK";
                taken = true;
                audioSource.Play();
                pda_previewImage.load_texture = null;
                Destroy(this.gameObject);
            }

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if(taken == true)
            {
                pdaController.pda_update = "Yoink";
                pda_previewImage.load_texture = null;

            } else
            {
                pdaController.pda_update = "Moving on...";
                pda_previewImage.load_texture = null;
            }
            
        }
    }
}
