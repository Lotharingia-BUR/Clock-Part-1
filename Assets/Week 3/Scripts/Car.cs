using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Car : MonoBehaviour
{
    float forwardInput;
    float steeringInput;
    public float forwardSpeed = 500;
    public float steeringSpeed = 200;
    public float maxSpeed = 450;
    Rigidbody2D rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rigidbody.AddTorque(steeringInput * -steeringSpeed * Time.deltaTime);
        Vector2 force = transform.up * forwardInput * forwardSpeed * Time.deltaTime;
        if (rigidbody.velocity.magnitude < maxSpeed)
        {
            rigidbody.AddForce(force);
        }
    }

    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        steeringInput = Input.GetAxis("Horizontal");
    }
}
