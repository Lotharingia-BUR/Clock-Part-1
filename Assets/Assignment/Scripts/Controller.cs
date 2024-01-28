using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    Rigidbody2D rigidbody;
    public Transform controller;
    float thrustInput;
    public float speed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 mov = transform.up * thrustInput * speed * Time.deltaTime;
        transform.Translate(mov);
    }

    void FixedUpdate()
    {
        thrustInput = Input.GetAxis("Vertical");
        if (thrustInput > 0)
        {
            thrustInput = 0;
        }
    }
}
