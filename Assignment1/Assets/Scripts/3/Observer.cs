/*
 * Nathan McNaughton
 * Score.cs
 * Assignment 3
 * Abstract, allows the inheriting class to be notified by a subject
 */
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Observer : MonoBehaviour
{
    abstract public void OnNotify();
}
