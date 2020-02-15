using UnityEngine;
using System.Collections;

namespace DecoratorPatternWithGameObjects
{
    public class ProfessionWarrior : ProfessionDecorator
    {
        Character character;

        public ProfessionWarrior(Character character)
        {
            this.character = character;
        }

        public override string GetDescription()
        {
            return character.GetDescription() + " Warrior";
        }

        public override int GetDamage()
        {
            return character.GetDamage() + 10;
        }
    }
}