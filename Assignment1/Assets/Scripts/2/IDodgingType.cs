/*
 * Nathan McNaughton
 * Assignment 2
 * IDodgingType.cs
 * Interface and implementation of different dodging behaviors
 */
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

    public TeleportDodge(GameObject self)
    {
        this.self = self;
    }

    public void Dodge()
    {
        if (Random.Range(0, 2) == 1)
            negative = 1;
        else
            negative = -1;

        self.transform.position = new Vector3((Random.Range(1, 4) + self.transform.position.x) * negative , (Random.Range(1, 4) + self.transform.position.y), (Random.Range(1, 4) + self.transform.position.z) * negative);
    }
}

public class JumpDodge : IDodgingType
{
    public GameObject self;

    public JumpDodge(GameObject self)
    {
        this.self = self;
    }

    public void Dodge()
    {
        self.GetComponent<Rigidbody>().velocity = new Vector3(0f, 1.0f, 0f) * Random.Range(15.0f, 25.0f);
    }
}

public class NoDodge : IDodgingType
{
    public void Dodge()
    {

    }
}
