using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPatternWithGameObjects
{

    //If Enemy extends MonoBehaviour, you can attach its concrete subclasses to GameObjects
    //but Unity will throw an error if you try to instantiate the classes with the new keyword

    //So, you just drag the EnemySpider (or EnemyRobot, etc.) script/class onto the GameObjects 
    //that it applies to, or use AddComponent<EnemySpider>() to add the class at runtime.
    public abstract class Enemy: MonoBehaviour
    {
        public IAttackBehavior AttackBehavior;

        //public IAttackBehavior AttackBehavior { get; set; }
        public ISpecialAbilityBehavior SpecialAbilityBehavior { get; set; }

        public ChangeColorBehavior ChangeColorBehavior { get; set; }

        //Performs the attack behavior.  Virtual means this method can be overridden by a subclass.
        public virtual void DoAttack() { AttackBehavior.Attack(); }

        //Performs the special ability behavior.
        public virtual void DoSpecialAbility() { SpecialAbilityBehavior.SpecialAbility(); }

        //Performs the color change behavior.
        public virtual void DoChangeColor() { ChangeColorBehavior.ChangeColor(); }


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

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                DoChangeColor();
            }

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                Destroy(GetComponent<ChangeColorBehavior>());
                ChangeColorBehavior = gameObject.AddComponent<ChangeColorRed>();
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                Destroy(GetComponent<ChangeColorBehavior>());
                ChangeColorBehavior = gameObject.AddComponent<ChangeColorBlue>();
            }

            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                Destroy(GetComponent<ChangeColorBehavior>());
                ChangeColorBehavior = gameObject.AddComponent<ChangeColorGreen>();
            }

        }


    }

}