/* Example Code for Game Programming Design Patterns
 * Author: Owen Schaffer
 * This example inspired by Anton Rynkovoy https://gist.github.com/antonrynkovoy/a9e7f3776fcaff6a7de667600f3d3110
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPatternWithGameObjects
{
    public class RaceElf : Character
    {

        public RaceElf()
        {
            this.description = "Elf";
        }

        public override int GetDamage()
        {
            return 10;
        }
    }

}