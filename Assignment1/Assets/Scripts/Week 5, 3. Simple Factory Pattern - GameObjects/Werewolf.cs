using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleFactoryPatternWithGameObjects
{
    public class Werewolf : Enemy
    {

        void Start()
        {
            this.EnemyType = "Werewolf";
            this.Weapon = "Claw";
            this.Damage = 8;
            this.Speed = 4.0f;
        }


        void OnEnable()
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
        }

    }
}