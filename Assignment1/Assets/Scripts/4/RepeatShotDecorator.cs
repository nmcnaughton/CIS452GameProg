using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatShotDecorator : ShotDecorator
{
    IShot newShot;

    public RepeatShotDecorator(IShot shot)
    {
        newShot = shot;
    }

    public override int GetNumber()
    {
        return newShot.GetNumber() + 1;
    }

    public override float GetSize()
    {
        return newShot.GetSize();
    }
}
