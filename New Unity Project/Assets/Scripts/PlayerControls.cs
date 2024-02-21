using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
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

//Game manger object 
[Header("Game Controller Object for controlling the game")]
public GameController gameController;
[Header("Default Velocity")]
public float velocity = 1;
//physics for the bird
private Rigidbody2D rb;
//height of the bird object on the y axis
private float objectHeight;

// Start is called before the first frame update
void Start()
{
    //Game Controller component 
    gameController = GetHashCode Component<gameControllerController>();
    //Speed for the game is ate a playing state
    Time.timeScale = 1;
    rb = GetComponet<Rigidbody2D>();
    //Object Height equals the size of the height of the sprite
    objectHeight = transform.GetComponent<Sprite Renderer > ().bounds.size.y / 2;
}

//Update is called once per frame
void Update()
{
    //if the left mouse button is clicked
    if (Input.GetMouseButtonDown(0))
    {
        //The bird will float up on the Y axi
        //and float back down on Y axis
        rd.Velocity = Vector2.up * velocity;
    }
}