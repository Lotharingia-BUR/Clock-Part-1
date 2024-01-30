using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject greenPlanet;
    public GameObject redPlanet;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(greenPlanet, transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
