using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TractorBeam : MonoBehaviour
{
    public GameObject tractorBeam;
    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) 
        {
            Debug.Log("space down");
            spriteRenderer.color = Color.red;
            tractorBeam.SetActive(true);
        } else
        {
            spriteRenderer.color = Color.white;
            tractorBeam.SetActive(false);
        }
    }
}
