using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BagController : MonoBehaviour
{

    // Public variables we want to expose to the editor...
    public static float bag_weight = 0f;
    public static int monies = 0;
    public int extr_monies = 0;
    public static int health = 40;
    public static bool alarm = false;
    public Text explainer_text;
    public static bool bag_weight_change = false;
    public bool alarm_muscic_on = false;

    // vars
    public GameObject lostMonies;
    public GameObject lostHearts;
    public bool alive = true;
    public bool extracted = false;

    // Audio things
    public AudioClip main_loop;
    public AudioClip allert_loop;
    public AudioClip hit_1;
    public AudioClip hit_2;
    public AudioClip hit_3;

    public AudioSource audioSource;
    public AudioSource oneOffs;



    // Start is called before the first frame update
    void Start()
    {
        audioSource.loop = true;
        audioSource.clip = main_loop;
        audioSource.volume = 0.4f;
        audioSource.Play();
        monies = 0;
        health = 40;
        alarm = false;
    }

    // Update is called once per frame
    void Update()
    {   

        if (health > 0)
        {
            alive = true;
        }
        else
        {
            alive = false;
        }

        if (extracted == false)
        {
            explainer_text.text = "You have " + monies + " monies, and your health is at " + health;
        }

        if (alarm == true && alarm_muscic_on == false)
        {
            audioSource.Stop();
            audioSource.loop = true;
            audioSource.clip = allert_loop;
            audioSource.volume = 0.6f;
            audioSource.Play();
            alarm_muscic_on = true;
        }


        if (alive == false)
        {
            health = 40;
            monies = 0;
            alarm = false;
            SceneManager.LoadScene("dead", LoadSceneMode.Single);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            exitGame();
        }

    }



    private void updateHeft()
    {
        Move2D.speed = Move2D.speed - bag_weight;
        bag_weight_change = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Gaurd")
        {
            if (monies > 0 && alarm == true)
            {
                monies = monies - 5;
                GameObject monies_ps = (GameObject)GameObject.Instantiate(lostMonies);
                monies_ps.transform.position = transform.position;
                oneOffs.PlayOneShot(hit_1, 0.8F);
            }
            else
            {
                if (health > 0 && alarm == true)
                {
                    health = health - 3;
                    GameObject heart_ps = (GameObject)GameObject.Instantiate(lostHearts);
                    heart_ps.transform.position = transform.position;
                    oneOffs.PlayOneShot(hit_3, 0.8F);
                }
            }
        }

        if (collision.gameObject.tag == "Finish")
        {
            // this.GetComponent<Renderer>().enabled = false; << invisable!
            Debug.Log("extracted");
            alarm = false;
            alive = true;
            extracted = true;
            explainer_text.text = "You have extracted with " + monies + " monies, and your health is at " + health;
            SceneManager.LoadScene("win", LoadSceneMode.Single);
            regMusic();

        }

    }


    void regMusic()
    {
        audioSource.loop = true;
        audioSource.clip = main_loop;
        audioSource.volume = 0.4f;
        audioSource.Play();
        alarm = false;
    }

    void exitGame()
    {
        SceneManager.LoadScene("dead", LoadSceneMode.Single);
    }

}
