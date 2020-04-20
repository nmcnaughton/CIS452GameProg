using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Damage : MonoBehaviour, IGameManagement
{
    int health = 4;
    Text healthText;
    GameObject manager;


    void Start()
    {
        healthText = GameObject.FindGameObjectWithTag("Health").GetComponent<Text>();
        manager = GameObject.FindGameObjectWithTag("Manager");

    }

    void SetText()
    {
        healthText = GameObject.FindGameObjectWithTag("Health").GetComponent<Text>();
    }

    public void Success()
    {
        //Successfully destroyed the enemy, no health lost
    }

    public void Fail()
    {
        if (healthText == null)
        {
            SetText();
        }
        health--;
        healthText.text = "Health: " + health;
    }

    void Update()
    {
        if (health <= 0)
        {
            manager.GetComponent<GameManager11>().StopAllCoroutines();
            manager.GetComponent<GameManager11>().LoseGame();
        }
    }
}
