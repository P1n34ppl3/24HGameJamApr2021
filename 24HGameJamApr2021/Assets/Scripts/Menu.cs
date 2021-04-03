using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject Startscreen;
    public GameObject InGame;
    public GameObject player;
    public PlayerMovement playerMovement;


    void Start()
    {   
        Startscreen.SetActive(true);
        InGame.SetActive(false);
        player = GameObject.Find("Player");
        playerMovement = player.GetComponent<PlayerMovement>();
        playerMovement.enabled = false;
    }
    public void PlayGame()
    {
        Startscreen.SetActive(false);
        InGame.SetActive(true);
        playerMovement.enabled = true;
    }
    public void Death()
    {
        Startscreen.SetActive(true);
        InGame.SetActive(false);
        playerMovement.enabled = false;
    }
    public void Quit()
    {
        Application.Quit();
    }
}