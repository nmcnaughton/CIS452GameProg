using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPattern
{

    public abstract class Enemy
    {
        public IAttackBehavior AttackBehavior { get; set; }
        public ISpecialAbilityBehavior SpecialAbilityBehavior { get; set; }

        //Performs the attack behavior.  Virtual means this method can be overridden by a subclass.
        public virtual void DoAttack() { AttackBehavior.Attack(); }

        //Performs the special ability behavior.
        public virtual void DoSpecialAbility() { SpecialAbilityBehavior.SpecialAbility(); }

        /*  //this is not needed because we have default getters and setters on the property above
        public void setAttackBehavior (IAttackBehavior ab)
        {
            attackBehavior = ab;
        }
        */

        //abstract methods must be implemented by concrete sub-classes
        public abstract void Die();

        //Unlike interfaces, abstract classes can have concrete methods
        //These concrete methods are inherited by sub-classes
        public void speak() { Debug.Log("I'm an enemy. Fear me!"); }

    }

    public class EnemySpider : Enemy
    {
        public EnemySpider()
        {
            AttackBehavior = new AttackBite();
            SpecialAbilityBehavior = new SpecialAbilityWebSpray();

        }
        public override void Die()
        {
            Debug.Log("The spider dies.");
            //add death animations and particle effects for spider death here
        }
    }

    public class EnemyBoxer : Enemy
    {
        public EnemyBoxer()
        {
            AttackBehavior = new AttackPunch();
            SpecialAbilityBehavior = new SpecialAbilityBodySlam();
        }
        public override void Die()
        {
            Debug.Log("The boxer dies.");
            //add death animations and particle effects for boxer death here
        }
    }

    public class EnemyRobot : Enemy
    {
        public EnemyRobot()
        {
            AttackBehavior = new AttackLaser();
            SpecialAbilityBehavior = new SpecialAbilityBodySlam();
        }

        // We can use an overloaded constructor to pass in 
        // behaviors that are not the defaults above
        public EnemyRobot(IAttackBehavior attack, ISpecialAbilityBehavior specialAbility)
        {
            AttackBehavior = attack;
            SpecialAbilityBehavior = specialAbility;
        }
               
        public override void Die()
        {
            Debug.Log("The robot dies.");
            //add death animations and particle effects for robot death here
        }
    }

}