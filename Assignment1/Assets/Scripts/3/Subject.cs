/*
 * Nathan McNaughton
 * Subject.cs
 * Assignment 3
 * Handles adding removing and notifying the observers
 */
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Subject : MonoBehaviour
{
    List<Observer> observers;

    virtual public void AddObserver(Observer observer)
    {
        if (observers == null)
        {
            observers = new List<Observer>();
        }

        observers.Add(observer);
    }

    virtual public void RemoveObserver(Observer observer)
    {
        if (observers == null)
        {
            observers = new List<Observer>();
        }

        observers.Remove(observer);
    }

    virtual public void Notify()
    {
        if (observers == null)
        {
            observers = new List<Observer>();
        }

        foreach (Observer o in observers)
        {
            o.OnNotify();
        }
    }
}
