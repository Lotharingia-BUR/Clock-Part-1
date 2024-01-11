using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Missile : MonoBehaviour
{
    // Variables
    float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed, 0, 0);
    }
}
