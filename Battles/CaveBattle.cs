using ProjectAdventure.CharacterClasses.Common;
using System;
using System.Collections.Generic;
using ProjectAdventure.CharacterClasses.Enemies;
using System.Linq;

namespace ProjectAdventure.Battles
{
    class CaveBattle : Battle
    {
        public CaveBattle(List<BaseFighter> units) : base(units)
        {
            Enemies = new List<BaseFighter>();
            Enemies.Add(new Dragon() { CharacterName = "Raysses" });

            foreach (var enemy in Enemies)
            {
                enemy.IncreaseLevel();
                enemy.IncreaseLevel();
                enemy.IncreaseLevel();
                enemy.IncreaseLevel();
                enemy.IncreaseLevel();
            }

            IsFinalBattle = false;
        }

        public override void DetermineNextBattle()
        {

            Console.WriteLine();
            Console.WriteLine("After completing their final upgrade the adventurers need to determine if they should go East or West.");
            Console.WriteLine("Please type 'Left' or 'Right' and press enter.");
            var nextBattle = Console.ReadLine();
            if (nextBattle == null)
            {
                NextBattle = new DeepForrestBattle(Units);
            }
            else if (nextBattle.ToLower() == "east")
            {
                NextBattle = new BoxBattle(Units);
            }
            else if (nextBattle.ToLower() == "west")
            {
                NextBattle = new LabBattle(Units);
            }
        }

        public override void PostBattleInteraction()
        {
            Console.WriteLine();
            Console.WriteLine("After defeating the dragon, everyone starts to look through the stacks of treasure.");
            Console.WriteLine("As each looks through piles they find something that piques their interest.");
            Console.WriteLine("Each warrior is given 2 choices and depending on their choice will determine the next path of their journey.");
            var newUnits = new List<BaseFighter>();

            foreach (var unit in Units)
            {
                Console.WriteLine($"{unit.CharacterName} the {unit.CharacterType} has the following choices: ");
                foreach (var upgradeItem in unit.UpgradeItems)
                {
                    Console.WriteLine(upgradeItem);
                }
                Console.WriteLine("Which item will you take? Type your option and press enter.");
                var line = Console.ReadLine();

                var item = unit.UpgradeItems.First(x => x.ToString().ToLower() == line.ToLower());
                if (!unit.UpgradeItems.Contains(item))
                {
                    item = unit.UpgradeItems[0];
                }

                var newUnit = unit.UpgradeClass(item);
                newUnit.IncreaseLevel();

                Console.WriteLine($"{newUnit.CharacterName} is now a {newUnit.CharacterType}");
                newUnits.Add(newUnit);
            }

            Units = newUnits;
        }

        public override void PreBattleInteraction()
        {
            Console.WriteLine();
            Console.WriteLine("After entering the cave the adventures notice piles of gold all over in giant piles.");
            Console.WriteLine("The cave begins to darken as a giant shadow overtakes the cave.");
            Console.WriteLine($"A solemn voice speaks a grave warning before a fireball is shot in the direction of {Units[0].CharacterName}.");
        }
    }
}
