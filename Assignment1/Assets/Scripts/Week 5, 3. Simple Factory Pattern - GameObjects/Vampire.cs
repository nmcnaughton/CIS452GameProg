using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleFactoryPatternWithGameObjects
{
    public class Vampire : Enemy
    {
        //We use start instead of a constructor because Enemy extends MonoBehaviour
        void Start()
        {
            this.EnemyType = "Vampire";
            this.Weapon = "Bite";
            this.Damage = 10;
            this.Speed = 5.0f;
        }

        void OnEnable()
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        }

    }
}