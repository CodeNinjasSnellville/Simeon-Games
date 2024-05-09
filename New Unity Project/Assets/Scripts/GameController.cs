using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Start is called before the first frame update
        void Start()
        {
            //Speed for the game is at a playing state
            Time.timeScale = 1;
            //Score in visible
            scoreCanvas.SetActive(true);
            //Game Over UI is invisible
            gameOverCanvas.SetActive(false);
            //The spawer is shown in the game
            spawner.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {





        //Game Over Canvas that is used for the game
        [Hearder("Game Over UI Object for displaying Game Over Screen ")]
        public GameObject gameOverCanvas;
        //Score Canvas that is used for the game
        [Header("Score UI Object for displaying Score")]
        public GameObject scoreCanvas;
        //Spawer object that is used for the game
        [Header("Spawner Object for spawning object in game")]
        public GameObject spawner;
    }

puiblc void GameOver()
{
        //Game over UI is visible 
        gameOverCanvas.setActive(true);
        //The spawer is now invisible in the game  
        spawner.SetActive(false);
        //The speed for the game is now at a stopping state
        Time.timeScale = 0;
}