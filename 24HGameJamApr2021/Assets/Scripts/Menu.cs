using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject Startscreen;
    public GameObject InGame;
    public GameObject always;
    public GameObject player;
    public GameObject enemySpawner;
    public PlayerMovement playerMovement;
    public EnemySpawning enemySpawning;
    public  MovingScreen movingScreen;
    public Score score;


    void Start()
    {   
        score = always.GetComponent<Score>();

        Startscreen.SetActive(true);

        InGame.SetActive(false);  

        playerMovement = player.GetComponent<PlayerMovement>();
        playerMovement.enabled = false;

        enemySpawning = enemySpawner.GetComponent<EnemySpawning>();
        enemySpawning.enabled = false;

        movingScreen = player.GetComponent<MovingScreen>();
        movingScreen.enabled = true;

    }

    public void PlayGame()
    {
        Startscreen.SetActive(false);
        InGame.SetActive(true);
        
        playerMovement.enabled = true;
        enemySpawning.enabled = true;
        Score.CurrentScore = 0;
        movingScreen.enabled = false;


    }
    public void Death()
    {
        Startscreen.SetActive(true);
        InGame.SetActive(false);

        playerMovement.enabled = false;
        enemySpawning.enabled = false;
        movingScreen.enabled = true;

    }
    public void Quit()
    {
        Application.Quit();
    }
}