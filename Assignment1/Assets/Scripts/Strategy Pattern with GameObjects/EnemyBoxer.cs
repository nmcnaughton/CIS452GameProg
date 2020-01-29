using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPatternWithGameObjects
{
    public class EnemyBoxer : Enemy
    {
        public IAttackBehavior AttackBehavior;

        public EnemyBoxer()
        {
            //AttackBehavior = new AttackPunch();
            SpecialAbilityBehavior = new SpecialAbilityBodySlam();
        }
        public override void Die()
        {
            Debug.Log("The boxer dies.");
            //add death animations and particle effects for boxer death here
            Destroy(gameObject);
        }
    }
}