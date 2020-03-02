using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealShapeFactory : ShapeFactory
{
    public GameObject sphere;
    public GameObject cube;
    public GameObject spawnObject;
    public override GameObject CreateShape(string input)
    {
        switch (input)
        {
            case "Cube":
                spawnObject = cube;
                return spawnObject;
            case "Sphere":
                spawnObject = sphere;
                return spawnObject;
        }
        return null;
    }
}
