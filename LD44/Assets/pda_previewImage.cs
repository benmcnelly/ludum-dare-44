using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pda_previewImage : MonoBehaviour
{
    Sprite spriteImageCompenent;

    public Sprite loaded_sprite;
    public static Sprite current_sprite;

    private void Awake()
    {
        spriteImageCompenent = GetComponent<Sprite>();
    }


    // Start is called before the first frame update
    void Update()
    {
        if (current_sprite)
        {
            spriteImageCompenent = current_sprite;
        }
    }

    void updateSprite()
    {

    }

}
