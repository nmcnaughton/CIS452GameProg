using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swirl : MonoBehaviour, IDodgeState
{
    float timeCount;

    public Vector3 Dodge()
    {
        timeCount += Time.deltaTime * 8f;
        return new Vector3(Mathf.Cos(timeCount), Mathf.Sin(timeCount), 0);
    }

    public Vector3 SuperDodge()
    {
        timeCount += Time.deltaTime * 2f;
        return new Vector3(Mathf.Cos(timeCount) * 8, Mathf.Sin(timeCount) * 8, 0);
    }
}
