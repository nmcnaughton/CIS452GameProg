/* Exampcle Code for Game Programming Design Patterns
 * Author: Owen Schaffer
 * This example inspired by Anton Rynkovoy https://gist.github.com/antonrynkovoy/a9e7f3776fcaff6a7de667600f3d3110
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//We add this to import the UI namespace from UnityEngine
//So we can get the Text UI component with GetComponent<Text>().text
using UnityEngine.UI;

namespace DecoratorPatternWithGameObjects
{
    public class CharacterCreator : MonoBehaviour
    {
        //This reference holds the character object being created
        public Character character;
        
        
        /*void Start()
        {
           
        }*/

        // Update is called once per frame
        /*void Update()
        {

        }*/

          // We could create the object and add decorators with
          // one method per setting:
/*        public void SetRaceElf()
        {
            this.character = new RaceElf();
            DisplayCharacter();
        }

        public void SetRaceTroll()
        {
            this.character = new RaceTroll();
            DisplayCharacter();
        }

        public void AddProfessionWarrior()
        {
            this.character = new ProfessionWarrior(character);
            DisplayCharacter();
        }

        public void AddProfessionWizard()
        {
            this.character = new ProfessionWizard(character);
            DisplayCharacter();
        }*/

        // This has to be called from a button wired in the inspector
        // and a string with "Elf" or "Troll" needs to be 
        // passed in as an argument.
        public void SetRace(string newCharacter)
        {
            switch (newCharacter)
            {
                case "Elf":
                    this.character = new RaceElf();
                    break;
                case "Troll":
                    this.character = new RaceTroll();
                    break;
                default:
                    Debug.LogError("No character race called " + newCharacter);
                    break;
            }
            DisplayCharacter();
        }

        //This has to be called from a button wired in the inspector
        //and a string needs to be passed in as an argument
        public void AddProfession(string newProfession)
        {
            switch (newProfession)
            {
                case "Warrior":
                    this.character = new ProfessionWarrior(character);
                    break;
                case "Wizard":
                    this.character = new ProfessionWizard(character);
                    break;
            }
            //Then update the display
            DisplayCharacter();
        }

        public void DisplayCharacter()
        {
            gameObject.GetComponent<Text>().text = character.GetDescription() + 
                " does " + character.GetDamage() + " damage.";
        }

    }
}