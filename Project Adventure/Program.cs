using ProjectAdventure.CharacterClasses.Fighter;
using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.Battles;
using ProjectAdventure.CharacterClasses.Mage;
using System.Collections.Generic;
using ProjectAdventure.CharacterClasses.Entertainer;
using System;
using ProjectAdventure.CharacterClasses.Scholar;

namespace Project_Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Our story begins like any other in a tavern of course.");
                Console.WriteLine("One of our heros is greeted by a shrouded stranger who asks...");
                Console.WriteLine("What is your name young warrior?");
                var name = Console.ReadLine();

                Console.WriteLine($"Greetings, {name}");

                Console.WriteLine();
                Console.WriteLine("Are you a 'Squire', 'Mage', 'Entertainer', or 'Scholar'?");
                var characterClass = Console.ReadLine();

                BaseFighter player1 = GetCharacterClass(characterClass, name);

                Console.WriteLine();
                Console.WriteLine($"Shortly after meeting the stranger another warrior joins the table and the stanger again asks what is your name?");
                name = Console.ReadLine();

                Console.WriteLine($"Greetings, {name}");

                Console.WriteLine();
                Console.WriteLine("Are you a 'Squire', 'Mage', 'Entertainer', or 'Scholar'?");
                characterClass = Console.ReadLine();

                BaseFighter player2 = GetCharacterClass(characterClass, name);

                Console.WriteLine();
                Console.WriteLine($"One last warrior sits around the table and is asked what is your name?");
                name = Console.ReadLine();

                Console.WriteLine($"Greetings, {name}");

                Console.WriteLine();
                Console.WriteLine("Are you a 'Squire', 'Mage', 'Entertainer', or 'Scholar'?");
                characterClass = Console.ReadLine();
                BaseFighter player3 = GetCharacterClass(characterClass, name);

                var units = new List<BaseFighter>() { player1, player2, player3 };

                var gameOver = false;

                Battle battle = new CityStreetBattle(units);
                while (!battle.IsFinalBattle && !gameOver)
                {
                    battle.PreBattleInteraction();
                    gameOver = battle.BeginBattle();
                    if (!gameOver)
                    {
                        battle.PostBattleInteraction();
                        battle.DetermineNextBattle();
                        battle = battle.NextBattle;
                    }
                }

                if (!gameOver)
                {
                    battle.PreBattleInteraction();
                    gameOver = battle.BeginBattle();
                    battle.PostBattleInteraction();
                }

                if (gameOver)
                {
                    Console.WriteLine("This journey may be over but you can always try again.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.ReadKey();
            }
        }

        private static BaseFighter GetCharacterClass(string characterClass, string name)
        {
            if(characterClass.ToLower() == "squire")
            {
                return new Squire() { CharacterName = name, IsUserControlled = true };
            }
            else if (characterClass.ToLower() == "mage")
            {
                return new Mage() { CharacterName = name, IsUserControlled = true };
            }
            else if (characterClass.ToLower() == "entertainer")
            {
                return new Entertainer() { CharacterName = name, IsUserControlled = true };
            }
            else if (characterClass.ToLower() == "scholar")
            {
                return new Scholar() { CharacterName = name, IsUserControlled = true };
            }
            else
            {
                return new Squire() { CharacterName = name, IsUserControlled = true };
            }
        }
    }
}
