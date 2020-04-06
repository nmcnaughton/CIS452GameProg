using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strafe : MonoBehaviour, IDodgeState
{
    bool flip = false;
    float x = 0;
    


    public Vector3 Dodge()
    {
        if (flip)
        {
            x += 8f * Time.deltaTime;
            if (x > 5)
            {
                flip = false;
            }
        }
        else
        {
            x -= 8f * Time.deltaTime;
            if ( x < -5)
            {
                flip = true;
            }
        }
        return new Vector3(x, 0, 0);
    }

    public Vector3 SuperDodge()
    {
        if (flip)
        {
            x += 24f * Time.deltaTime;
            if (x > 11)
            {
                flip = false;
            }
        }
        else
        {
            x -= 24f * Time.deltaTime;
            if (x < -11)
            {
                flip = true;
            }
        }
        return new Vector3(x, 0, 0);
    }
}
