using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearingTarget : Target, DodgingInterface, DestroyInterface
{
    public int disappearTime;

    public override void TargetHit()
    {
        Debug.Log("DisappearingTarget.TargetHit : Target will teleport to a new location on each hit");
    }

    public void DodgeBullet()
    {
        Debug.Log("DisappearingTarget.DodgeBullet : Target will phase out for 'disappearTime' seconds and teleport to a new location");
    }

    public void DestroyObject()
    {
        Debug.Log("DisappearingTarget.DestroyObject : Target will shatter and phase out");
    }
}
