using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleFactoryPatternWithText
{
    public class Zombie : Enemy
    {

        public Zombie()
        {
            this.EnemyType = "Zombie";
            this.Weapon = "Bite";
            this.Damage = 7;
            this.Speed = 3.0f;
        }
    }
}