using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControls : MonoBehaviour
{
    //Rigibody2D object that is stored
    [Header("Rigidbody")]
    public Rigidbody2D rb;
    [Header("Defalut Down Speed")]
    //downward speed of the object
    public float downSpeed = 20f;
    [Header("Default Down Speed")]
    //movement speed of the object
    public float movementSpeed = 10f;
    [Header("Default Directional Movement Speed")]
    //movement direction of the object
    public float movement = 0f;

    //Start is called before the first frame update
    void Start()
    {
        //variable equals to componet Rigidbody2D
        rb = GetComponent<Rigidbody2D>();
        //movement equals Horizontal movement
        //multiplied by the movement speed
       
    }

    
        //Fixedupdate called every fixed frame-rate frame.
        void FixedUpdate()
        {
        movement = Input.GetAxis("Horizontal") * movementSpeed;
        //if direction on x aixs is les than 0
        if (movement < 0)

            //object faces to the left
            this.GetComponent<SpriteRenderer>().flipX = false;

        //if diredtion on x axis is greater than 0
        else
        {
            //object faces to the right
            this.GetComponent<SpriteRenderer>().flipX = true;
        }
    }  

}

