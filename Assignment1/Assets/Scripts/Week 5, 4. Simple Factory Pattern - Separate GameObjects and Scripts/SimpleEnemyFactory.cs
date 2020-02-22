using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleFactoryPatternWithSeparateGameObjectsAndClasses
{

    //Attach this class to an empty GameObject
    public class SimpleEnemyFactory : MonoBehaviour
    {

        private GameObject enemyToSpawn;

        public GameObject AddEnemyScript(GameObject prefab, string type)
        {
            enemyToSpawn = prefab;

            if (type.Equals("Zombie"))
            {

                //If there is not already a Zombie script attached to the prefab, attach one
                if (enemyToSpawn.GetComponent<Zombie>() == null)
                {
                    enemyToSpawn.AddComponent<Zombie>();
                }
            }
            else if (type.Equals("Vampire"))
            {

                //If there is not already a Vampire script attached to the prefab, attach one
                if (enemyToSpawn.GetComponent<Vampire>() == null)
                {
                    enemyToSpawn.AddComponent<Vampire>();
                }

            }
            else if (type.Equals("Werewolf"))
            {

                //If there is not already a Werewolf script attached to the prefab, attach one
                if (enemyToSpawn.GetComponent<Werewolf>() == null)
                {
                    enemyToSpawn.AddComponent<Werewolf>();
                }

            }

            Debug.Log("Factory sending: " + enemyToSpawn);
            return enemyToSpawn;
        }

    }
}