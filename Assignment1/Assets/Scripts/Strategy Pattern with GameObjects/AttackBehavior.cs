using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPatternWithGameObjects
{

    public class AttackPunch : MonoBehaviour, IAttackBehavior
    {
        public void Attack()
        {
            Debug.Log("The enemy punches you!");

            //We can't use GetComponent<>() because this class is 
            //not attached to any GameObject.
            
            //GetComponent<MeshRenderer>().material.color = Color.red;
            
            //We would have to get a reference to the GameObject first

        }
    }

    public class AttackBite : IAttackBehavior
    {
        public void Attack()
        {
            Debug.Log("The enemy bites you!");
            //GetComponent<MeshRenderer>().material.color = Color.blue;
        }
    }

    public class AttackLaser : MonoBehaviour, IAttackBehavior
    {
        public void Attack()
        {
            Debug.Log("The enemy shoots you with a LASER BEAM!");
            //GetComponent<MeshRenderer>().material.color = Color.white;
        }
    }

}