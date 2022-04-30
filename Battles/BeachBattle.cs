using ProjectAdventure.CharacterClasses.Common;
using System;
using System.Collections.Generic;
using ProjectAdventure.CharacterClasses.Enemies;
using System.Linq;

namespace ProjectAdventure.Battles
{
    class BeachBattle : Battle
    {
        public BeachBattle(List<BaseFighter> units) : base(units)
        {
            Enemies = new List<BaseFighter>();
            Enemies.Add(new Captain() { CharacterName = "Greybeard" });
            Enemies.Add(new Pirate() { CharacterName = "Elias" });
            Enemies.Add(new Pirate() { CharacterName = "Sylvia" });

            foreach (var enemy in Enemies)
            {
                enemy.IncreaseLevel();
                enemy.IncreaseLevel();
                enemy.IncreaseLevel();
            }

            IsFinalBattle = false;
        }

        public override void DetermineNextBattle()
        {

            Console.WriteLine();
            Console.WriteLine("After completing their final upgrade the adventurers need to determine if they should go North or South.");
            Console.WriteLine("Please type 'North' or 'South' and press enter.");
            var nextBattle = Console.ReadLine();
            if (nextBattle == null)
            {
                NextBattle = new DeepForrestBattle(Units);
            }
            else if (nextBattle.ToLower() == "north")
            {
                NextBattle = new BoxBattle(Units);
            }
            else if (nextBattle.ToLower() == "south")
            {
                NextBattle = new CemetaryBattle(Units);
            }
        }

        public override void PostBattleInteraction()
        {
            Console.WriteLine();
            Console.WriteLine("With the pirate crew defeated, everyone starts to look through the stacks of treasure again.");
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
            Console.WriteLine("Everyone comes upon a wrecked ship. They begin searching it.");
            Console.WriteLine("While searching a voice yells that is our treasure and an ambush begins on our adventures.");
        }
    }
}
