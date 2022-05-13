using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floating : MonoBehaviour
{
    public float degreesPerSecond;//= 15.0f;
    public float amplitude;// = 0.5f;
    public float frequency;// = 1f;

    // Position Storage Variables
    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();

    // Use this for initialization
    void Start()
    {
        degreesPerSecond = Random.Range(5.0f, 20.0f);
        amplitude = Random.Range(0.2f, 0.7f);
        frequency = Random.Range(0.1f, 1.0f);
        // Store the starting position & rotation of the object
        posOffset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Spin object around Y-Axis
        transform.Rotate(new Vector3(0f, Time.deltaTime * degreesPerSecond, 0f), Space.World);

        // Float up/down with a Sin()
        tempPos = posOffset;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;

        transform.position = tempPos;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == 9)
        {
            Destroy(this);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 9)
        {
            Destroy(this);
        }
    }
}
