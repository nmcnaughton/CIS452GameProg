using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ShotDecorator : IShot
{
    public abstract float GetSize();
    public abstract int GetNumber();
}
