/*
 * Nathan McNaughton
 * Score.cs
 * Assignment 3
 * Handles updating the score
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : Observer
{
    public GameManager3 manager;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager3>();
    }

    public override void OnNotify()
    {
        if (manager == null)
        {
            manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager3>();
        }

        manager.score += manager.scorePoints;
        manager.scoreText.GetComponent<Text>().text = "Score: " + manager.score;
    }
}
