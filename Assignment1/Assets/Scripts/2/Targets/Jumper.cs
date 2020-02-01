﻿using System.Collections;
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
            SwitchDodge(new JumpDodge());
            switched = true;
        }

        TryToDodge();
    }
}