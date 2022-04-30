using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Enemies;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectAdventure.Battles
{
    public class ForrestBattle : Battle
    {
        public ForrestBattle(List<BaseFighter> units) : base(units)
        {
            
            Enemies = new List<BaseFighter>();
            Enemies.Add(new Bear() { CharacterName = "Koda"});

            IsFinalBattle = false;
        }

        public override void DetermineNextBattle()
        {
            Console.WriteLine();
            Console.WriteLine("After upgrading their weapons and armor our adventures have a choice to make as to where they next travel.");
            Console.WriteLine("There are three options open to the adventures. In the distance to the West is smoke as if from another campfire, head deeper into the forrest to the North or will the party travel to the East to a visible clearing leading toward the sea? Please type 'Smoke', 'Forrest', 'Clearing' and press enter.'");
            var nextBattle = Console.ReadLine();
            if (nextBattle == null)
            {
                NextBattle = new DeepForrestBattle(Units);
            }
            else if (nextBattle.ToLower() == "smoke")
            {
                NextBattle = new SmokeBattle(Units);
            }
            else if (nextBattle.ToLower() == "forrest")
            {
                NextBattle = new DeepForrestBattle(Units);
            }
            else if (nextBattle.ToLower() == "clearing")
            {
                NextBattle = new ClearingBattle(Units);
            }
        }

        public override void PostBattleInteraction()
        {
            Console.WriteLine();
            Console.WriteLine("While walking through the woods the adventures stumble upon what looks like an old house. They knock.");
            Console.WriteLine("No answer but the door comes slightly ajar. They enter and beginning looking around where each of them finds a chest and opens them.");
            Console.WriteLine("Each warrior is given 4 choices and depending on their choice will determine the next path of their journey.");
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
                if(!unit.UpgradeItems.Contains(item))
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
            Console.WriteLine("Upon Making it to the Forrest the party looks to set up their camp. They get a fire going, make supper and pitch their tents.");
            Console.WriteLine("After telling stories of past adventures.The party passes out for the night. Before going to bed though everyone forgot to hang up the food");
            Console.WriteLine("After drifting off to sleep they hear something intruding in the camp.");
        }
    }
}
