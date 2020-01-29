using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPattern
{

    public interface IAttackBehavior
    {
        void Attack();

    }
    public interface ISpecialAbilityBehavior
    {
        void SpecialAbility();

    }

}