using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//We add this to import the UI namespace from UnityEngine
//So we can get the Text UI component with GetComponent<Text>().text
using UnityEngine.UI;

namespace SimpleFactoryPatternWithGameObjects
{

//Attach this class to an empty GameObject
    public class EnemySpawner : MonoBehaviour
    {
        //Need to attach the simple factory GameObject to this reference in the inspector
        public SimpleEnemyFactory factory;

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
            enemy = factory.CreateEnemy(type);
            Debug.Log(enemy);


            float xRand = Random.Range(-10, 10);
            float zRand = Random.Range(-10, 10);
            Vector3 spawnPos = playerOrCameraTransform.position +
                               playerOrCameraTransform.forward * spawnDistance +
                               new Vector3(xRand, 0, zRand);
            Instantiate(enemy, spawnPos, playerOrCameraTransform.rotation);

        }

    }
}