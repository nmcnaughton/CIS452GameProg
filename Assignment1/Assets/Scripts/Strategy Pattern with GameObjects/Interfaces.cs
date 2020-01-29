using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPatternWithGameObjects
{

    public interface IAttackBehavior
    {
        void Attack();

    }
    public interface ISpecialAbilityBehavior
    {
        void SpecialAbility();

    }

    //IChangeColorBehavior had to be changed to an abstract class to extend MonoBehaviour
    //so it could be called with    Destroy(GetComponent<ChangeColorBehavior>());
    //in the Enemy script.
    //This is because interfaces cannot extend MonoBehaviour.
    //And GetComponent<type>() can only be called on classes that extend MonoBehaviour.
    public abstract class ChangeColorBehavior : MonoBehaviour
    {
        public abstract void ChangeColor();
    }

}