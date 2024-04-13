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


    [Header("Default Speed")]
    //Speed for the movement
    public float speed;



    //Update is called once per frame
    void Update()
    {
        //Transform the object to move to left
        //according to the axis and speed
        transform.position += Vector3.left * speed * Time.deltaTime
    }
}


//Function where the player collides with a object
private void OnCollisionEnter2D(Collision2D collision)
{
    if(collision.gameObject.tag == "HighSpike" || collision.gameObject.tag == "LowSpike" || collision.gameObject.tag == "Ground")
    {
        ??Game is Attribute a stopping state
            Time.timeScale = 0;
    }
}