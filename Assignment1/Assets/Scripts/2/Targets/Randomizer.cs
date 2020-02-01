using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomizer : Target2
{
    void Start()
    {
        hits = 4;
        points = 20;
        dodge = new NoDodge();
    }

    public override void TargetHit()
    {
        hits--;
        if (hits <= 0)
        {
            Break();
        }

        if (Random.Range(0, 2) == 0)
        {
            SwitchDodge(new JumpDodge());
            gameObject.GetComponent<Rigidbody>().useGravity = true;
        }
        else
        {
            SwitchDodge(new TeleportDodge());
            gameObject.GetComponent<Rigidbody>().useGravity = false;
        }

        TryToDodge();
    }
}
