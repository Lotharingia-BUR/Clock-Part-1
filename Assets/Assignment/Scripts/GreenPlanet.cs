using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPlanet : MonoBehaviour
{
    Rigidbody2D rigidbody;
    GameObject goal;
    GameObject beam;
    float speed = 2f;

    void Start()
    {
        beam = GameObject.Find("Player Character/Ship Bottom/Tractor Beam Pointer");
        goal = GameObject.Find("Bounding Box/Green Goal");
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            speed *= -1;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Vector2 force = speed * (transform.position - beam.transform.position);
        rigidbody.AddForce(force);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == goal)
        {
            Destroy(gameObject);
        }
    }
}
