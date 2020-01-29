using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace StrategyPatternWithGameObjects
{

    public class ChangeColorBlue : ChangeColorBehavior
    {
        public override void ChangeColor()
        {
            Debug.Log("Color Change blue");
            GetComponent<MeshRenderer>().material.color = Color.blue;

        }
    }

    public class ChangeColorRed : ChangeColorBehavior
    {
        public override void ChangeColor()
        {
            Debug.Log("Color Change red");
            GetComponent<MeshRenderer>().material.color = Color.red;

        }
    }

    public class ChangeColorGreen : ChangeColorBehavior
    {
        public override void ChangeColor()
        {
            Debug.Log("Color Change green");
            GetComponent<MeshRenderer>().material.color = Color.green;

        }
    }

    public class ChangeColorYellow : ChangeColorBehavior
    {
        public override void ChangeColor()
        {
            Debug.Log("Color Change yellow");
            GetComponent<MeshRenderer>().material.color = Color.yellow;

        }
    }

}