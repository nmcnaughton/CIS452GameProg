using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleFactoryPattern
{
    public class Werewolf : Enemy
    {

        public Werewolf()
        {
            this.EnemyType = "Werewolf";
            this.Weapon = "Claw";
            this.Damage = 8;
            this.Speed = 4.0f;
        }
    }
}