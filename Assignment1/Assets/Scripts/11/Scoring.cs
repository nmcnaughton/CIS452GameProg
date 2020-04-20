using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour, IGameManagement
{
    Text scoreText;
    int score = 0;

    void Start()
    {
        scoreText = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();
    }

    void SetText()
    {
        scoreText = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();
    }

    public void Success()
    {
        if (scoreText == null)
        {
            SetText();
        }
        score += 10;
        scoreText.text = "Score: " + score;
    }
    
    public void Fail()
    {
        if (scoreText == null)
        {
            SetText();
        }
        score -= 5;
        scoreText.text = "Score: " + score;
    }
}
