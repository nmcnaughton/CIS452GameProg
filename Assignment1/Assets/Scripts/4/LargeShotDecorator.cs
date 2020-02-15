using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeShotDecorator : ShotDecorator
{
    IShot newShot;

    public LargeShotDecorator(IShot shot)
    {
        newShot = shot;
    }

    public override int GetNumber()
    {
        return newShot.GetNumber();
    }

    public override float GetSize()
    {
        return newShot.GetSize() + 0.5f;
    }
}
