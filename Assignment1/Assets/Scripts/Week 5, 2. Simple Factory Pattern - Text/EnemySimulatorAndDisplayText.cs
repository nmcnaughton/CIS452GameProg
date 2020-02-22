using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//We add this to import the UI namespace from UnityEngine
//So we can get the Text UI component with GetComponent<Text>().text
using UnityEngine.UI;

namespace SimpleFactoryPatternWithText
{

    public class EnemySimulatorAndDisplayText : MonoBehaviour
    {
        SimpleEnemyFactory factory;
        EnemySpawnerTheClientClass spawner;
        Enemy enemy;

        // Start is called before the first frame update
        void Start()
        {
            factory = new SimpleEnemyFactory();
            spawner = new EnemySpawnerTheClientClass(factory);
        }

        public void SpawnEnemy(string type)
        {
            enemy = spawner.SpawnEnemy(type);
            DisplayEnemy();
        }

        public void DisplayEnemy()
        {
            gameObject.GetComponent<Text>().text = enemy.ToString();
        }

    }
}