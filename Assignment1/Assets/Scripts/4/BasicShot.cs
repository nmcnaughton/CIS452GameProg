using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicShot : IShot
{
    float size = 1;
    int number = 1;

    public GameObject controls;

    public float GetSize()
    {
        return size;
    }

    public int GetNumber()
    {
        return number;
    }
}
