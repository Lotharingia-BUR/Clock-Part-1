using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TractorBeam : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Color tractorLight;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRender.color = tractorLight;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Debug.Log("space down");
            spriteRenderer.color = Color.red;
        }
    }
}
