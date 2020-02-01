using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int time = 120;
    private int seconds;
    public string timeString;
    public GameObject timeText;
    public GameObject scoreText;
    public GameObject gameOver;

    public void RunGame()
    {
        StartCoroutine(CountDown());
    }

    public IEnumerator CountDown()
    {
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
        

    }
    //Spawn in range of x/z -5 to -1, 1 to 5 
}
