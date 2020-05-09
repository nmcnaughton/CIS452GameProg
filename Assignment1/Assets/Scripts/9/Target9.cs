/*
 * Nathan McNaughton
 * Assignment 2
 * Target2.cs
 * Implementation of basic target functions. Named target2 due to assignment 1 already having a Target.cs file.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target9 : MonoBehaviour
{
    public float size;
    public int hits = 3;
    public int points;
    public IDodgeState idle;
    public IDodgeState swirl;
    public IDodgeState strafe;

    public IDodgeState dodge;
    public bool switched = false;

    Vector3 orig;

    void Start()
    {
        idle = new Idle();
        swirl = new Swirl();
        strafe = new Strafe();
        dodge = idle;
        orig = gameObject.transform.position;
    }

    public void TargetHit()
    {
        hits--;
        if (hits <= 0)
        {
            Break();
        }
        else if (hits == 2)
        {
            if (Random.Range(0, 2) == 0)
            {
                dodge = strafe;
            }
            else
            {
                dodge = swirl;
            }
        }
    }

    public void Break()
    {
        GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager3>().addPoints(this.points);
        Destroy(this.gameObject);
    }

    void Update()
    {
        if (hits == 2)
        {
            gameObject.transform.position = (orig + dodge.Dodge());
        }
        if (hits == 1)
        {
            gameObject.transform.position = (orig + dodge.SuperDodge());
        }



    }
}
