/*
 * Nathan McNaughton
 * Score.cs
 * Assignment 3
 * Handles updating the time
 */
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : Observer
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

        manager.time--;
        manager.seconds = manager.time % 60;
        if (manager.seconds < 10)
            manager.timeString = "Time: " + (manager.time / 60) + ":0" + manager.seconds;
        else
            manager.timeString = "Time: " + (manager.time / 60) + ":" + (manager.time % 60);
        manager.timeText.GetComponent<Text>().text = manager.timeString;
    }
}
