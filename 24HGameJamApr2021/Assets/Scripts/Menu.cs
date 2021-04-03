using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject Startscreen;
    public GameObject InGame;
    public GameObject player;


    void Start()
    {   
        Startscreen.SetActive(true);
        InGame.SetActive(false);
        player = GameObject.Find("Player");
        player.GetComponent<PlayerMovement>().enabled = false;
    }
    public void PlayGame()
    {
        Startscreen.SetActive(false);
        InGame.SetActive(true);

    }
    public void Death()
    {
        Startscreen.SetActive(true);
        InGame.SetActive(false);
    }
    public void Quit()
    {
        Application.Quit();
    }
}