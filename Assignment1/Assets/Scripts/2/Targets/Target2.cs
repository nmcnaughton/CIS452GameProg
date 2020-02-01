/*
 * Nathan McNaughton
 * Assignment 2
 * Target2.cs
 * Implementation of basic target functions. Named target2 due to assignment 1 already having a Target.cs file.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Target2 : MonoBehaviour
{
    public float size;
    public int hits;
    public int points;
    public IDodgingType dodge;
    public bool switched = false;

    public virtual void TargetHit()
    {
        hits--;
        if (hits <= 0)
        {
            Break();
        }

        TryToDodge();
    }

    public virtual void Break()
    {
        GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>().addPoints(this.points);
        Destroy(this.gameObject);
    }

    public void TryToDodge()
    {
        dodge.Dodge();
    }

    public void SwitchDodge(IDodgingType switchDodge)
    {
        dodge = switchDodge;
    }
}
