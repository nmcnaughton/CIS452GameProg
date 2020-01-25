using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingTarget : Target, DodgingInterface, DestroyInterface
{
    public override void TargetHit()
    {
        Debug.Log("JumpingTarget.TargetHit : Target will stop its momentum and fall to the ground");
    }

    public void DodgeBullet()
    {
        Debug.Log("JumpingTarget.DodgeBullet : Target will jump to a height of 'jumpHeight', repeating until it is hit");
    }

    public void DestroyObject()
    {
        Debug.Log("JumpingTarget.DestroyObject : Target will fall to the ground, tip over backwards, and explode");
    }
}