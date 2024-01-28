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
        thrustInput = Input.GetAxis("Vertical");
        rotateInput = Input.GetAxis("Horizontal");
        /*if (thrustInput < 0)
        {
            thrustInput = 0;
        }*/
    }

    void FixedUpdate()
    {
        /**//*Vector2 move = thrustInput * tSpeed * Time.deltaTime;*/
        transform.Translate(0f, thrustInput * tSpeed * Time.deltaTime, 0f);
        rigidbody.AddTorque(rotateInput * -rSpeed * Time.deltaTime);
    }
}
