using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleFactoryPattern
{
    public class EnemySimulator : MonoBehaviour
    {
        SimpleEnemyFactory factory;
        EnemySpawnerTheClientClass spawner;

        // Start is called before the first frame update
        void Start()
        {
            factory = new SimpleEnemyFactory();
            spawner = new EnemySpawnerTheClientClass(factory);

            Enemy enemy = spawner.SpawnEnemy("Zombie");





        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                Enemy enemy = spawner.SpawnEnemy("Zombie");
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                Enemy enemy = spawner.SpawnEnemy("Vampire");
            }

            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                Enemy enemy = spawner.SpawnEnemy("Werewolf");
            }

        }
    }
}