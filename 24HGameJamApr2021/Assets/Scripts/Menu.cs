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
    public Score score;
    public static bool playerIsDead;


    void Start()
    {   
        score = always.GetComponent<Score>();

        Startscreen.SetActive(true);

        InGame.SetActive(false);  

        playerMovement = player.GetComponent<PlayerMovement>();
        playerMovement.enabled = false;

        enemySpawning = enemySpawner.GetComponent<EnemySpawning>();
        enemySpawning.enabled = false;

        playerIsDead = false;
    }

    void Update()
    {
        if (playerIsDead)
        {
            Death();
        }
    }
    public void PlayGame()
    {
        Startscreen.SetActive(false);
        InGame.SetActive(true);
        
        playerMovement.enabled = true;
        enemySpawning.enabled = true;
        score.ResetScore();
    }
    public void Death()
    {
        Startscreen.SetActive(true);
        InGame.SetActive(false);

        playerMovement.enabled = false;
        enemySpawning.enabled = false;

        playerIsDead = false;
    }
    public void Quit()
    {
        Application.Quit();
    }
}