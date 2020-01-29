using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPattern
{

    public class EnemySimulator : MonoBehaviour
    {
        public Enemy spidey;

        public Enemy[] enemies = new Enemy[5];

        public List<Enemy> enemiesList = new List<Enemy>();

        // Start is called before the first frame update
        void Start()
        {
            //Part 1: One Spider

            Debug.Log("Make a new Spider.");

            spidey = new EnemySpider();

            Debug.Log("Spidey's attack: " + spidey.AttackBehavior);
            spidey.DoAttack();

            spidey.AttackBehavior = new AttackLaser();

            Debug.Log("Spidey's attack: " + spidey.AttackBehavior);
            spidey.DoAttack();

            //Part 2: a polymorphic array of enemies each attack
            /*
            enemies[0] = new EnemyBoxer();
            enemies[1] = new EnemyRobot();
            enemies[2] = new EnemySpider();
            enemies[3] = new EnemyBoxer();
            enemies[4] = new EnemySpider();

            //the next line causes an index out of bounds exception because the index ranges from 0 to 4
            //enemies[5] = new EnemyRobot();

            foreach (Enemy enemy in enemies)
            {
                if(enemy == null) { break; }

                enemy.DoAttack();
            }
            */

            //Part 3: a polymorphic list of enemies each attack
            /*

            //Add 9 enemies to the list
            for (int i = 0; i < 3; i++)
            {
                enemiesList.Add(new EnemyBoxer());
                enemiesList.Add(new EnemyRobot());
                enemiesList.Add(new EnemySpider());
            }

            //The List size expands and contracts as needed, 
            //so adding more will not cause an index out of bounds exception
            enemiesList.Add(new EnemyRobot());

            //Remove enemy at index position 9
            enemiesList.RemoveAt(9);

            //Remove the 3 enemies at positions 6-8
            enemiesList.RemoveRange(6, 3);

            foreach (Enemy enemy in enemiesList)
            {
                if (enemy == null) { break; }
                enemy.DoAttack();
            }
            */

        }

        // Example of using keyboard input to directly change behaviors at runtime
        // Note: this is just one way to do this - there are many 
        // ways you could change behaviors at runtime
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                spidey.DoAttack();
            }

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                spidey.AttackBehavior = new AttackLaser();
                Debug.Log("Spidey's attack: " + spidey.AttackBehavior);
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                spidey.AttackBehavior = new AttackBite();
                Debug.Log("Spidey's attack: " + spidey.AttackBehavior);
            }

            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                spidey.AttackBehavior = new AttackPunch();
                Debug.Log("Spidey's attack: " + spidey.AttackBehavior);
            }


        }

    }

}