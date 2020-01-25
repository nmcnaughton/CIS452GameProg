/*
 * Nathan McNaughton 
 * Target.cs
 * Assignment 1
 * Contains dummy method
 */
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Target
{
    public int size;
    public const int MAX_HEALTH = 2;
    private int currentHealth;

    public abstract void TargetHit();
}
