using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Target2 : MonoBehaviour
{
    public float size;
    public int hits;
    public int points;
    public IDodgingType dodge;
    public bool switched = false;

    public virtual void TargetHit()
    {
        hits--;
        if (hits <= 0)
        {
            Break();
        }

        TryToDodge();
    }

    public void Break()
    {
        Destroy(this.gameObject);
    }

    public void TryToDodge()
    {
        dodge.Dodge();
    }

    public void SwitchDodge(IDodgingType switchDodge)
    {
        dodge = switchDodge;
    }
}
