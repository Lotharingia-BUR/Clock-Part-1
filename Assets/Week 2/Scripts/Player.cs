using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector2 direction;
    public Rigidbody2D rigidbody;
    public float force = 150f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // fixed update ever 0.2s
    private void FixedUpdate()
    {
        rigidbody.AddForce(direction * force * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");
    }
}
