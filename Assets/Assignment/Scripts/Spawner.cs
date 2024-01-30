using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject greenPlanet;
    public GameObject redPlanet;
    public Transform spawnPoint;

    /*Vector3 spawn;*/
    // Start is called before the first frame update
    void Start()
    {
        spawnPoint.position = new Vector3(0f, 0f, 0f);
        spawnGreen(1, 1);
        spawnGreen(-4, -4);
        spawnGreen(-1, -1);
        spawnGreen(18, 5);
        spawnGreen(2, 2);
        spawnGreen(3, -5);
        spawnGreen(-10, -7);
        spawnGreen(-1, -1);
        spawnGreen(-1, -2);
        spawnGreen(-12, -2);
        spawnGreen(1, 2);

        spawnPoint.position = new Vector3(0f, 0f, 0f);

        spawnRed(-7, 1);
        spawnRed(0, -2);
        spawnRed(1, -3);
        spawnRed(17, -3);
        spawnRed(1.4f, 2);
        spawnRed(-7.6f, -4);
        spawnRed(0.2f, 6);
        spawnRed(0.2f, -3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnGreen(float x, float y)
    {
        transform.DetachChildren();
        transform.Translate(x, y, 0f);
        Instantiate(greenPlanet, spawnPoint);
    }

    void spawnRed(float x, float y)
    {
        transform.Translate(x, y, 0f);
        Instantiate(redPlanet, spawnPoint);
        transform.DetachChildren();
    }
}
