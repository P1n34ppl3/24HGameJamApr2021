using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int CurrentScore = 0;
    public static int HighScore = 0;

    void Update()
    {
        if (HighScore < CurrentScore)
        {
            HighScore = CurrentScore;
        }
    }

    void IncrementScore()
    {
        CurrentScore += 1;
    }

    void ResetScore()
    {
        CurrentScore = 0;
    }
}

