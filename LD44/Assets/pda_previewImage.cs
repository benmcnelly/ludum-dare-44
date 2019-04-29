using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pda_previewImage : MonoBehaviour
{
    RawImage self_RawImage;
    public Texture start_texture;
    public static Texture load_texture;

    private void Start()
    {
        self_RawImage = GetComponent<RawImage>();
        self_RawImage.texture = start_texture;
    }

    // Start is called before the first frame update
    void Update()
    {
        if (load_texture != null)
        {
            self_RawImage = GetComponent<RawImage>();
            self_RawImage.texture = load_texture;
        } else
        {
            self_RawImage = GetComponent<RawImage>();
            self_RawImage.texture = start_texture;
        }
    }


}
