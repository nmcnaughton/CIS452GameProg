/*
 * Nathan McNaughton
 * Assignment 2
 * Teleporter.cs
 * Teleporter target's class, applies behavior when shot
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : Target2
{
    void Start()
    {
        hits = 4;
        points = 25;
        dodge = new NoDodge();
    }

    public override void TargetHit()
    {
        hits--;
        if (hits <= 0)
        {
            Break();
        }

        if (!switched)
        {
            SwitchDodge(new TeleportDodge(gameObject));
            gameObject.GetComponent<Rigidbody>().useGravity = false;
            switched = true;
        }

        TryToDodge();
    }
}
