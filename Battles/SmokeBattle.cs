using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Enemies;
using System;
using System.Collections.Generic;

namespace ProjectAdventure.Battles
{
    public class SmokeBattle : Battle
    {
        public SmokeBattle(List<BaseFighter> units) : base(units)
        {
            Enemies = new List<BaseFighter>();
            Enemies.Add(new Imp() { CharacterName = "Mxyzptlk" });
            Enemies.Add(new Imp() { CharacterName = "Lucy" });

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
            Console.WriteLine("As the travelers journey toward the smoke they begin to notice a lights flickering.");
            Console.WriteLine("They also begin to hear two creatures laughing and jumping around. They see two small beings starting a fire.");
            Console.WriteLine("The warriors jump out and attack the two imps.");
        }
    }
}
