using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPatternWithGameObjects
{

    public class EnemySpider : Enemy
    {
        //Now that Enemy extends Monobehavior,
        //it is better to use Awake() than a constructor
        public void Awake()
        {
            
            AttackBehavior = new AttackBite();
            SpecialAbilityBehavior = new SpecialAbilityWebSpray();

            //And we use gameObject.AddComponent<ChangeColorBlue>(); instead of new
            //to add the ChageColorBlue script/class to the EnemySpider on Awake()
            ChangeColorBehavior = gameObject.AddComponent<ChangeColorBlue>();

        }



        public override void Die()
        {
            Debug.Log("The spider dies.");
            //add death animations and particle effects for spider death here
            Destroy(gameObject);
        }

        

    }
}