using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeShapeFactory : ShapeFactory
{
    public GameObject fakeSphere;
    public GameObject fakeCube;
    public GameObject spawnObject;
    public override GameObject CreateShape(string input)
    {
        switch (input)
        {
            case "Cube":
                spawnObject = fakeCube;
                return spawnObject;
            case "Sphere":
                spawnObject = fakeSphere;
                return spawnObject;
        }
        return null;
    }
}
