using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDodgingType
{
    void Dodge();
}

public class TeleportDodge : IDodgingType
{
    public GameObject self;
    private int negative;

    public void Dodge()
    {
        if (Random.Range(0, 2) == 1)
            negative = 1;
        else
            negative = -1;

        self.transform.position = new Vector3(Random.Range(1, 6) * negative, Random.Range(1, 6), Random.Range(1, 6) * negative);
    }
}

public class JumpDodge : IDodgingType
{
    public GameObject self;

    public void Dodge()
    {
        self.GetComponent<Rigidbody>().AddForce(self.transform.up * Random.Range(1.0f, 4.0f));
    }
}

public class NoDodge : IDodgingType
{
    public void Dodge()
    {

    }
}
