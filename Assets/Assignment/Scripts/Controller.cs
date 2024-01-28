using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    Rigidbody2D rigidbody;
    public Transform controller;
    float thrustInput;
    float rotateInput;
    public float tSpeed = 4f;
    public float rSpeed = 4f;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 move = transform.up * thrustInput * tSpeed * Time.deltaTime;
        transform.Translate(move);
        transform.Rotate(rotate);
    }

    void FixedUpdate()
    {
        thrustInput = Input.GetAxis("Vertical");
        rotateInput = Input.GetAxis("Horizontal");
        if (thrustInput > 0)
        {
            thrustInput = 0;
        }
    }
}
