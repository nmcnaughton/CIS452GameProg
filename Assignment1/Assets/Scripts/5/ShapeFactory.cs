using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeFactory : MonoBehaviour
{
    public GameObject cubePrefab;
    public GameObject spherePrefab;
    public GameObject spawnObject;
    public GameObject CreateShape(string input)
    {
        switch(input)
        {
            case "Cube":
                spawnObject = cubePrefab;
                return spawnObject;
            case "Sphere":
                spawnObject = spherePrefab;
                return spawnObject;
        }

        return null;
    }
}
