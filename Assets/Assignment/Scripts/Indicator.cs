using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indicator : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Color push;
    public Color pull;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = push;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Rotate(0f,0f, 180f);
            if (spriteRenderer.color == push)
            {
                spriteRenderer.color = pull;
            } else
            {
                spriteRenderer.color = push;
            }
        }
    }
}
