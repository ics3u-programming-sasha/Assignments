using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameController : MonoBehaviour {
    public GameObject[] hazards;
    public Vector3 spawnValue;

    private int score;
    public int hazardCount;

    public float spawnWait;
    public float startwait;
    public float waveWait;

    public Text scoreText;
    public Text restartText;
    public Text gameOverText;
    public Text exitText;
    public Text pauseText;

    private bool restart;
    private bool gameOver;
    private bool exit;
    private bool pause;

    void Start()
    {
        //set score to 0
        score = 0;
        //calling function
        UpdateScore();
        //calling the function we write
        StartCoroutine(SpawnWaves());

        //setting bools to false
        restart = false;
        gameOver = false;
        pause = false;

        //setting text to nothing
        restartText.text = "";
        gameOverText.text = "";
        exitText.text = "";
        pauseText.text = "Press 'p' to pause";
    }

    void Update()
    {
        if (restart == true)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }

        if (exit == true)
        {
            //if e is pressed
            if (Input.GetKeyDown(KeyCode.E))
            {
                //closing the app
                Application.Quit();
            }
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            if (pause == false)
            {
                //calling pause
                Pause();
            }
            else
            {
                //calling restart
                Restart();
            }
        }
    }

    void Pause()
    {
        //seting the time to stop
        Time.timeScale = 0.0f;
        //showing that the game is paused
        pauseText.text = "Paused";
        //setting bool to true
        pause = true;
    }

    void Restart()
    {
        //setting the time to start
        Time.timeScale = 1.0f;
        //showing that the game is not paused
        pauseText.text = "Press 'p' to pause";
        //setting bool to false
        pause = false;
    }

    void UpdateScore()
    {
        //setting the score to label
        scoreText.text = "Score: " + score;
    }

    public void AddScore(int newScoreValue)
    {
        //adding to score
        score += newScoreValue;
        UpdateScore();
    }

    IEnumerator SpawnWaves()
    {
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                //picking a random hazard
                GameObject hazard = hazards[Random.Range(0, hazards.Length)];
               
                //wait for a certain time
                yield return new WaitForSeconds(startwait);

                //setting where the position will be 
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValue.x, spawnValue.x), spawnValue.y, spawnValue.z);
                Quaternion spawnRotation = Quaternion.identity;

                //creating a hazard
                Instantiate(hazard, spawnPosition, spawnRotation);

                //wait for a certain time
                yield return new WaitForSeconds(spawnWait);
            }
            //wait 
            yield return new WaitForSeconds(waveWait);

            if (gameOver == true)
            {
                //setting restart text
                restartText.text = "Press 'a' to restart";
                //set restart to true
                restart = true;

                //setting exit text
                exitText.text = "Press 'e' to exit";
                //set exit to true
                exit = true;

                break;
            }
        }
    }

    public void GameOver()
    {
        //set game over to true
        gameOver = true;
        //set text to game over
        gameOverText.text = "Game Over.";
    }

}
