using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager11 : MonoBehaviour
{
    public GameObject winText;
    public GameObject loseText;
    bool started = true;
    public Text scoreText;
    public Text healthText;

    int scoreReset = 0;
    
    public int time = 120;
    public int startTime;
    private int seconds;
    public string timeString;
    public GameObject timeText;

    public Button initial;
    public GameObject buttonCanvas;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0.1f;
    }

    public IEnumerator CountDown(int timeToPlay)
    {
        time = timeToPlay;
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
            
        }

        WinGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (healthText.text == "Health: 0")
        {
            StopAllCoroutines();
            LoseGame();
        }
    }

    public void WinGame()
    {
        winText.GetComponent<Text>().text = scoreText.text +" Try again for a higher score!";
        winText.transform.parent.gameObject.SetActive(true);
        winText.SetActive(true);
        buttonCanvas.SetActive(false);
    }

    public void LoseGame()
    {
        loseText.SetActive(true);
        loseText.transform.parent.gameObject.SetActive(true);
        buttonCanvas.SetActive(false);
    }

    public void ResetGame()
    {
        started = true;
        scoreText.text = "Score: 0";
        healthText.text = "Health: 4";
        timeText.GetComponent<Text>().text = "Time: 30";
        winText.SetActive(false);
        loseText.SetActive(false);

        Time.timeScale = 1.0f;

        buttonCanvas.SetActive(true);

        for (int i = 0; i < 10; i++)
        {
            buttonCanvas.transform.GetChild(i).GetComponent<Button>().onClick.RemoveAllListeners();
            buttonCanvas.transform.GetChild(i).GetComponent<Button>().onClick.AddListener(gameObject.GetComponent<Facade>().Miss);
        }

        StartCoroutine(CountDown(startTime));

        initial.onClick.RemoveAllListeners();
        initial.onClick.AddListener(gameObject.GetComponent<Facade>().Score);
        var colors = initial.colors;
        colors.normalColor = Color.green;
        colors.highlightedColor = Color.green;
        initial.colors = colors;
    }
}