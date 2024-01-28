using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    Rigidbody2D rigidbody;
    float thrustInput;
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float thruster = Input.GetAxis("Vertical");

        rigidbody.Translate(0, 0, 1);
    }

    void FixedUpdate()
    {

    }
}
