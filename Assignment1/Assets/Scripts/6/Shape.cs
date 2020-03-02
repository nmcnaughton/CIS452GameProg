using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    public abstract void ShapeHit();
    public abstract void Bounce();
}
