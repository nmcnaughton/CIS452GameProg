/*
 * Nathan McNaughton
 * Assignment 2
 * Jumper.cs
 * Class for the Jumping target, applies the behavior when shot
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : Target2
{
    void Start()
    {
        hits = 4;
        points = 15;
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
            SwitchDodge(new JumpDodge(gameObject));
            switched = true;
        }

        TryToDodge();
    }
}
