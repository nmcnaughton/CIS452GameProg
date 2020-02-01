/*
 * Nathan McNaughton
 * Assignment 2
 * GameManager.cs
 * Manages spawning targets, UI elements, and the game runtime.
 */
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int time = 120;
    public int startTime;
    private int seconds;
    public string timeString;
    public GameObject timeText;
    public GameObject scoreText;
    public GameObject gameOver;
    public GameObject gameOverButton;
    public GameObject controls;
    private int ballCount;
    public GameObject jumper;
    public GameObject teleporter;
    public GameObject randomizer;
    public int score;
    private int negative;
    public GameObject jumperTest;
    public GameObject gameOverText;
    private bool started = false;

    private void Start()
    {
        Cursor.lockState =  CursorLockMode.Locked;
        time = startTime;
    }

    public void RunGame()
    {
        StartCoroutine(CountDown(startTime));
        started = true;
        //reset score
        addPoints(-score);
    }

    public void StopGame()
    {
        started = false;
        GameObject[] targetsToDestroy = GameObject.FindGameObjectsWithTag("Target");
        for (int i = 0; i< targetsToDestroy.Length; i++)
        {
            Destroy(targetsToDestroy[i]);
        }
        gameOver.SetActive(true);
        if (score < 200)
            gameOverText.GetComponent<Text>().text = "You Lose! Get 200 to win";
        else
            gameOverText.GetComponent<Text>().text = "You Win!";
    }

    public IEnumerator CountDown(int timeToPlay)
    {
        time = timeToPlay;
        SpawnBall();
        while (time > 0)
        {
            yield return new WaitForSeconds(1.0f);
            time--;
            seconds = time % 60;
            if (seconds < 10)
                timeString = "Time: " + (time / 60) + ":0" + seconds;
            else
                timeString = "Time: " + (time / 60) + ":" + (time % 60);
            timeText.GetComponent<Text>().text = timeString;

            if (time % 5 == 0)
            {
                SpawnBall();
            }
        }

        StopGame();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            if(controls.activeInHierarchy)
            {
                controls.GetComponent<Button>().onClick.Invoke();
            }
            else if(gameOver.activeInHierarchy)
            {
                gameOverButton.GetComponent<Button>().onClick.Invoke();
            }
        }

        if (Input.GetKeyDown(KeyCode.Mouse0) && started)
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if(hit.transform.gameObject.tag == "Target")
                {
                    hit.transform.gameObject.GetComponent<Target2>().TargetHit();
                }
            }
        }

    }

    private void SpawnBall()
    {
        for (int i = 0; i < 2; i++)
        {
            if (Random.Range(0, 2) == 1)
                negative = 1;
            else
                negative = -1;

            var position = new Vector3(Random.Range(1, 16) * negative, Random.Range(4, 12), Random.Range(1, 16) * negative);

            int rand = Random.Range(1, 4);
            if (rand == 1)
            {
                Instantiate(jumper, position, Quaternion.identity);
            }
            else if (rand == 2)
            {
                Instantiate(teleporter, position, Quaternion.identity);
            }
            else if (rand == 3)
            {
                Instantiate(randomizer, position, Quaternion.identity);
            }
        }
    }

    public void addPoints(int points)
    {
        score += points;
        scoreText.GetComponent<Text>().text = "Score: " + score;
    }
}
