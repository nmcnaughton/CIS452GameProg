﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeEnemy : MonoBehaviour
{
    public GameObject target;
    public GameObject winTrigger;
    public int maxHealth = 4;
    int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        winTrigger = GameObject.FindObjectOfType<Controls>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, .3f * Time.deltaTime);
        transform.LookAt(target.transform);
    }

    public void LoseHealth()
    {
        currentHealth--;
        if (currentHealth <= 0)
        {
            GameObject.Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            winTrigger.GetComponent<Controls>().LoseGame();
        }
    }
}
