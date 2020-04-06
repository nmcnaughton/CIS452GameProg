using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : MonoBehaviour, IDodgeState
{
    public Vector3 Dodge()
    {
        //Sits pretty
        return Vector3.zero;
    }

    public Vector3 SuperDodge()
    {
        //Sits pretty
        return Vector3.zero;
    }
}
