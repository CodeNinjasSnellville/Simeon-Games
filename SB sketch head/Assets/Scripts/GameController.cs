using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    //Platform gameobject
    [Header("Platform Object")]
    public GameObject platform;
    //Defaut position for platform
    float pos = 0;
   
    // Update is called once per frame
    void Update()
    {
        //Interger i equals 1000
        for (int i = 0; i < 1000; i++)
        {
            //Execute SpawnPlatforms
            SpawnPlatforms();
        }
    }

    //Spawn platforms function
    void SpawnPlatforms()
    {
        //Spawn platforms randomly on the x axis and place them on the Y axis every 2.5
        Instantiate(platform, new Vector(Random.value * 10 -5f, pos, 0.5f), Quaternion.identity);
    }
}
