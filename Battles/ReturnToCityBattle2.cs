using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Enemies;
using System;
using System.Collections.Generic;

namespace ProjectAdventure.Battles
{
    public class ReturnToCityBattle2 : Battle
    {
        private List<BaseFighter> selectableEnemies = new List<BaseFighter>();

        public ReturnToCityBattle2(List<BaseFighter> units) : base(units)
        {
            Enemies = new List<BaseFighter>()
            {
                new SunLegion() { CharacterName = "Acire" },
                new MoonLegion() { CharacterName = "Erica" }
            };

            foreach (var unit in Enemies)
            {
                var selectableEnemy = unit.Clone();
                selectableEnemy.IsUserControlled = true;
                selectableEnemies.Add(selectableEnemy);
            }

            IsFinalBattle = false;
        }

        public override void DetermineNextBattle()
        {
            NextBattle = new ElementalBattle2(Units);
        }

        public override void PostBattleInteraction()
        {
            Console.WriteLine();
            Console.WriteLine("Passing the final test which unit would you like to add to your party?");
            for (int i = 1; i <= selectableEnemies.Count; i++)
            {
                var enemy = selectableEnemies[i - 1];
                Console.WriteLine($"{i}. {enemy.CharacterName} the {enemy.CharacterType}");
            }
            Console.WriteLine("Type the number of the unit you would like and press enter.");
            var unitNumber = Console.ReadLine();

            int.TryParse(unitNumber, out int selectedUnitNumber);

            if (selectedUnitNumber <= 0 || selectedUnitNumber > selectableEnemies.Count)
            {
                selectedUnitNumber = 1;
            }

            var selectedUnit = selectableEnemies[selectedUnitNumber - 1];
            Units.Add(selectedUnit);

            foreach (var unit in Units)
            {
                unit.IncreaseLevel();
            }
        }

        public override void PreBattleInteraction()
        {
            Console.WriteLine();
            Console.WriteLine("You hear a familiar voice say, 'You have proven yourself'.");
            Console.WriteLine("A second voice, that sounds similar to the first says, 'We will help after you pass our final test'");
            Console.WriteLine("The stranger who sent you on your journey reveals herself from under her covering.");
            Console.WriteLine("Beside her stands her sister who also reveals herself.");
            Console.WriteLine("They draw their spears and the final test begins.");
        }
    }
}
