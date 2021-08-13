using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNote : MonoBehaviour
{

    public float outerRadius = 4.5f;
    public float innerRadius = 3.0f;
    public float spawnDegree;//for testing

    public bool rotatingClockWise = true;//which way the hit bar is spinning

    public bool row = true;//true for outer radius, false for inner radius

    public GameObject blueNote;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()//outer radius = 4.5
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Spawn(spawnDegree, row);
        }
    }

    void Spawn(float degrees, bool row)//creates a note at the degree specified
    {
        float radians = degrees * Mathf.PI / 180;
        float yCoord = outerRadius * Mathf.Sin(radians);
        float xCoord = outerRadius * Mathf.Cos(radians);
        Vector3 spawnPoint = new Vector3(xCoord, yCoord, 0);
        Instantiate(blueNote, spawnPoint, Quaternion.AngleAxis(spawnDegree + 90, Vector3.forward));
    }
}
