using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleFactoryPatternWithText
{
    public class Vampire : Enemy
    {

        public Vampire()
        {
            this.EnemyType = "Vampire";
            this.Weapon = "Bite";
            this.Damage = 10;
            this.Speed = 5.0f;
        }
    }
}