using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleFactoryPatternWithText
{
    public class Enemy
    {
        protected string EnemyType { get; set; }
        protected string Weapon { get; set; }
        protected int Damage { get; set; }
        protected float Speed { get; set; }

        public void Attack()
        {
            Debug.Log("The " + this.EnemyType +
            " attacks with " + this.Weapon +
                     " for " + this.Damage + " damage.");
        }

        public void Move()
        {
            Debug.Log("The " + this.EnemyType +
                " moves at " + this.Speed + " speed.");

        }

        public override string ToString()
        {
            return "EnemyType: " + this.EnemyType + "\n" +
                      "Weapon: " + this.Weapon + "\n" +
                      "Damage: " + this.Damage;
        }

    }

}