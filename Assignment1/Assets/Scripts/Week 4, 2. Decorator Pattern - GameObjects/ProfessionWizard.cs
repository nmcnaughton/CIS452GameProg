using UnityEngine;
using System.Collections;

namespace DecoratorPatternWithGameObjects
{
    public class ProfessionWizard : ProfessionDecorator
    {
        Character character;

        public ProfessionWizard(Character character)
        {
            this.character = character;
        }

        public override string GetDescription()
        {
            return character.GetDescription() + " Wizard";
        }

        public override int GetDamage()
        {
            return character.GetDamage() + 5;
        }
    }
}