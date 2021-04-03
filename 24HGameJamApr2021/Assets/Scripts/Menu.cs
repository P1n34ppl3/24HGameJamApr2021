using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject Startscreen;
    public GameObject InGame;


    void Start()
    {
        Startscreen.SetActive(true);
        InGame.SetActive(false);
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