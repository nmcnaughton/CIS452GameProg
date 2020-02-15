/* Example Code for Game Programming Design Patterns
 * Author: Owen Schaffer
 * This example inspired by Anton Rynkovoy https://gist.github.com/antonrynkovoy/a9e7f3776fcaff6a7de667600f3d3110
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPatternWithGameObjects
{
    public abstract class ProfessionDecorator : Character
    {

        public override abstract string GetDescription();
    }
}