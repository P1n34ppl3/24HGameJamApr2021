using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Score : MonoBehaviour
{
    public static int CurrentScore = 5;
    public static int HighScore = 5;
    public TextMeshProUGUI highScoreText;
    public TextMeshProUGUI scoreText;


    void Update()
    {

        Debug.Log("check");
        highScoreText.text = HighScore.ToString();
        scoreText.text = CurrentScore.ToString();
        if (HighScore <= CurrentScore)
        {
            HighScore = CurrentScore;
        }
    }
}

