using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleFactoryPattern
{

    public class EnemySpawnerTheClientClass
    {
        public SimpleEnemyFactory factory;

        public EnemySpawnerTheClientClass(SimpleEnemyFactory factory)
        {
            this.factory = factory;
        }

        public Enemy SpawnEnemy(string type)
        {
            Enemy enemy;

            enemy = factory.CreateEnemy(type);

            enemy.Move();
            enemy.Attack();
            Debug.Log(enemy);

            return enemy;


        }

    
    }
}