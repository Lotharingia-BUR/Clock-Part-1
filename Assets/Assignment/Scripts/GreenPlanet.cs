using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPlanet : MonoBehaviour
{
    Rigidbody2D rigidbody;
    public Transform beam;
    public float speed = -1f;

    void Start()
    {
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
        Vector2 force = speed * (transform.position - beam.position);
        rigidbody.AddForce(force);
    }
}
