using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tire : MonoBehaviour
{
    Rigidbody2D rigidbody;
    // move down
    Vector2 direction = new Vector2(0, -2);
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + direction * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (direction.y < 0)
        {
            // move up
            direction = new Vector2(0, 2);
        } else
        {
            // move down
            direction = new Vector2(0, -2);
        }
        
    }
}
