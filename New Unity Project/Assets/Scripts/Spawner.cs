﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{ 

    
    //Object that we will attach to the script for spawning object
    [Header("Spikes object for controlling the game")]
    public GameObject spikes;
    //Height position of the spikes
    [Header("Default Height")]
    public float height;


    // Start is called before the frist frame update
    void Start()
    {
        //start function repeating every 4 seconds
        InvokeRepeating("InstantiateObjects", 1f, 4f);
    }


    // Update is called once per frame
    void Update()
    {
        //Position for the gameobjects
        transform.position = new Vector3(5, Random.Range(-height, height), 0);
    }

    //InstantiateObjects Function
    void Instantiate()
    {
        //Spawn object by postion and rotaion
        Instantiate(spikes, transform.position, transform.rotation);
}
}



