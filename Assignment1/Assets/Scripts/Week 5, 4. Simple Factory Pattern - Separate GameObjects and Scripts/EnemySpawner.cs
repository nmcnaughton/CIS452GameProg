using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//We add this to import the UI namespace from UnityEngine
//So we can get the Text UI component with GetComponent<Text>().text
using UnityEngine.UI;

namespace SimpleFactoryPatternWithSeparateGameObjectsAndClasses
{

//Attach this class to an empty GameObject
    public class EnemySpawner : MonoBehaviour
    {
        //Need to attach the simple factory GameObject to this reference in the inspector
        public SimpleEnemyFactory factory;
        public SimplePrefabFactory prefabFactory;

        private GameObject enemy;

        public float spawnDistance;

        private Transform playerOrCameraTransform;

        private void Start()
        {
            spawnDistance = 20f;
            playerOrCameraTransform = Camera.main.transform;
        }

        public void SpawnEnemy(string type)
        {
            Debug.Log("Type passed in: " + type);
            
            //This factory returns the prefab of the type
            enemy = prefabFactory.CreateEnemy(type);

            //This factory takes the prefab and adds the Enemy script of the type to it
            enemy = factory.AddEnemyScript(enemy, type);
            Debug.Log(enemy);

            //This code spawns the prefab at a random position within a certain range around a point
            //in front of the player or camera's position 
            //(depending on the Transform assigned to playerOrCameraTransform)
            float xRand = Random.Range(-10, 10);
            float zRand = Random.Range(-10, 10);
            Vector3 spawnPos = playerOrCameraTransform.position +
                               playerOrCameraTransform.forward * spawnDistance +
                               new Vector3(xRand, 0, zRand);
            Instantiate(enemy, spawnPos, playerOrCameraTransform.rotation);

        }

    }
}