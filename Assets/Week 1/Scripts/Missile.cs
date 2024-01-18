using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Missile : MonoBehaviour
{
    // Variables
    //float speed = 0.1f;
    Rigidbody2D rigidbody;
    Vector2 direction = new Vector2(10, 0);
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(speed, 0, 0);
    }

    // every 0.2s
    private void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + direction * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Missile Hit");
        Destroy(gameObject);
    }
}
