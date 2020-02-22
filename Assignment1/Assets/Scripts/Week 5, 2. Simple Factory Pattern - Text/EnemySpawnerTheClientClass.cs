using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleFactoryPatternWithText
{

    public class EnemySpawnerTheClientClass
    {
        public SimpleEnemyFactory factory;
        public Enemy enemy;

        public EnemySpawnerTheClientClass(SimpleEnemyFactory factory)
        {
            this.factory = factory;
        }

        public Enemy SpawnEnemy(string type)
        {
            enemy = factory.CreateEnemy(type);

            enemy.Move();
            enemy.Attack();
            Debug.Log(enemy);

            return enemy;

        }

    
    }
}