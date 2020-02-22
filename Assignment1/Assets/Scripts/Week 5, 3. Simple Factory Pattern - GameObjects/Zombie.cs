using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleFactoryPatternWithGameObjects
{
    public class Zombie : Enemy
    {
        //We use start instead of a constructor because Enemy extends MonoBehaviour
        void Start()
        {
            this.EnemyType = "Zombie";
            this.Weapon = "Bite";
            this.Damage = 7;
            this.Speed = 3.0f;
        }

        void OnEnable()
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
        }
    }
}