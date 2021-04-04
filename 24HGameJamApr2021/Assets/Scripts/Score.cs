using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Score : MonoBehaviour
{
    public static int CurrentScore = 0;
    public static int HighScore = 0;
    public TextMeshProUGUI highScoreText;
    public TextMeshProUGUI scoreText;
    void Update()
    {
        highScoreText.text = HighScore.ToString();
        scoreText.text = CurrentScore.ToString();
        if (HighScore <= CurrentScore)
        {
            HighScore = CurrentScore;
        }
    }
}

