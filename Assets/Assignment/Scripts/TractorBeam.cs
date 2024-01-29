using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TractorBeam : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public color onSwitch;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRender.color = onSwitch;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
