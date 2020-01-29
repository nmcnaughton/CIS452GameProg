using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPattern
{

    public class AttackPunch : IAttackBehavior
    {
        public void Attack()
        {
            Debug.Log("The enemy punches you!");
        }
    }

    public class AttackBite : IAttackBehavior
    {
        public void Attack()
        {
            Debug.Log("The enemy bites you!");
        }
    }

    public class AttackLaser : IAttackBehavior
    {
        public void Attack()
        {
            Debug.Log("The enemy shoots you with a LASER BEAM!");
        }
    }

}