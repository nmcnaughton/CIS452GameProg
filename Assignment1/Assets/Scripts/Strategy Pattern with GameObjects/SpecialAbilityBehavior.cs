using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPatternWithGameObjects
{

    public class SpecialAbilityBodySlam : ISpecialAbilityBehavior
    {
        public void SpecialAbility()
        {
            Debug.Log("The enemy slams you with its body!");
        }
    }

    public class SpecialAbilityWebSpray : ISpecialAbilityBehavior
    {
        public void SpecialAbility()
        {
            Debug.Log("The enemy sprays you with sticky webs!");
        }
    }

}