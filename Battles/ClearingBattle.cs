using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Entertainer;
using ProjectAdventure.CharacterClasses.Scholar;
using System;
using System.Collections.Generic;

namespace ProjectAdventure.Battles
{
    public class ClearingBattle : Battle
    {
        public ClearingBattle(List<BaseFighter> units) : base(units)
        {
            Enemies = new List<BaseFighter>();
            Enemies.Add(new Scholar() { CharacterName = "Chadwick" });
            Enemies.Add(new Entertainer() { CharacterName = "Jesse" });
            Enemies.Add(new Entertainer() { CharacterName = "James" });

            Enemies[0] = Enemies[0].UpgradeClass(UpgradeItemEnum.Dynamite);
            Enemies[1] = Enemies[1].UpgradeClass(UpgradeItemEnum.Microphone);
            Enemies[2] = Enemies[2].UpgradeClass(UpgradeItemEnum.Guitar);

            foreach (var enemy in Enemies)
            {
                enemy.IncreaseLevel();
                enemy.IncreaseLevel();
            }

            IsFinalBattle = false;
        }

        public override void DetermineNextBattle()
        {
            NextBattle = new CaveBattle(Units);
        }

        public override void PostBattleInteraction()
        {
            Console.WriteLine("After the battle Rain begins to pour. Up a head there is a cave and everyone ducks inside for cover.");
            foreach (var unit in Units)
            {
                unit.IncreaseLevel();
            }
        }

        public override void PreBattleInteraction()
        {
            Console.WriteLine();
            Console.WriteLine("Upon entering the clearing music begins to play. Songs are sung of travellers past all to an upbeat note or two.");
            Console.WriteLine("At the end of the song fireworks shoot off behind the makeshift stage. The bands music having stopped, the adventures ears still ring.");
            Console.WriteLine("At this point the warriors know what they must do and jump to take down the band.");
        }
    }
}
