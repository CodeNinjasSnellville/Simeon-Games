using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

[Header("Default Speed")]
//Speed for the movement
public float speed;

// Update is called once per frame
void Update()
{
    // Trasform the object to move to left
    // accordin to the axis and speed
    transform.position += Vector3.left * speed * Time.deltaTime;
}