using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ShapeFactory : MonoBehaviour
{
    public virtual GameObject CreateShape(string input)
    {
        switch(input)
        {
            default: break;
        }
        return null;
    }
}
