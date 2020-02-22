using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleFactoryPatternWithText
{

    public class SimpleEnemyFactory
    {

        public Enemy CreateEnemy(string type)
        {
            Enemy enemy = null;

            if (type.Equals("Zombie"))
            {
                enemy = new Zombie();
            }
            else if (type.Equals("Vampire"))
            {
                enemy = new Vampire();
            }
            else if (type.Equals("Werewolf"))
            {
                enemy = new Werewolf();
            }

            return enemy;
        }


    }
}