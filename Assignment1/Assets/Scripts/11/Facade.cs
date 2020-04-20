using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Facade : MonoBehaviour
{
    IGameManagement score;
    IGameManagement damage;
    IGameManagement target;

    void Start()
    {
        score = new Scoring();
        damage = new Damage();
        target = new NextTarget();
    }

    public void Score()
    {
        score.Success();
        damage.Success();
        target.Success();
    }
    
    public void Miss()
    {
        score.Fail();
        damage.Fail();
        target.Fail();
    }
}
