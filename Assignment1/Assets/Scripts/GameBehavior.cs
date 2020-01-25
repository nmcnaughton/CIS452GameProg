using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehavior : MonoBehaviour
{
    JumpingTarget smallJumper;
    JumpingTarget largeJumper;
    DisappearingTarget smallPhaser;
    DisappearingTarget largePhaser;

    List<Target> targets;
    List<DodgingInterface> dodgers;
    List<DestroyInterface> destroyableObjects;

    // Start is called before the first frame update
    void Start()
    {
        smallJumper = new JumpingTarget();
        largeJumper = new JumpingTarget();
        smallPhaser = new DisappearingTarget();
        largePhaser = new DisappearingTarget();

        smallJumper.TargetHit();
        smallJumper.DodgeBullet();
        smallJumper.DestroyObject();
        smallPhaser.TargetHit();
        smallPhaser.DodgeBullet();
        smallPhaser.DestroyObject();

        targets = new List<Target>()
        {
            smallJumper,
            largeJumper,
            smallPhaser,
            largePhaser,
        };

        dodgers = new List<DodgingInterface>()
        {
            smallJumper,
            largeJumper,
            smallPhaser,
            largePhaser,
        };

        destroyableObjects = new List<DestroyInterface>()
        {
            smallJumper,
            largeJumper,
            smallPhaser,
            largePhaser,
        };
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Alpha1) && Input.GetKey(KeyCode.Alpha2)) || 
                (Input.GetKeyDown(KeyCode.Alpha2) && Input.GetKey(KeyCode.Alpha1)))
        {
            foreach (DestroyInterface destroyable in destroyableObjects)
            {
                destroyable.DestroyObject();
            }
        }
        else if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            foreach (Target target in targets)
            {
                target.TargetHit();
            }
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            foreach (DodgingInterface dodger in dodgers)
            {
                dodger.DodgeBullet();
            }
        }
    }
}
