using ProjectAdventure.CharacterClasses.Common;
using System;
using System.Collections.Generic;
using ProjectAdventure.CharacterClasses.Fighter;

namespace ProjectAdventure.Battles
{
    class ArmyBattle : Battle
    {
        public ArmyBattle(List<BaseFighter> units) : base(units)
        {
            Enemies = new List<BaseFighter>();
            Enemies.Add(new Knight() { CharacterName = "Otis" });
            Enemies.Add(new Legion() { CharacterName = "Noy" });
            Enemies.Add(new Defender() { CharacterName = "Cristole" });

            foreach (var enemy in Enemies)
            {
                enemy.IncreaseLevel();
                enemy.IncreaseLevel();
                enemy.IncreaseLevel();
                enemy.IncreaseLevel();
            }

            IsFinalBattle = false;
        }

        public override void DetermineNextBattle()
        {
                NextBattle = new MirrorBattle(Units);
        }

        public override void PostBattleInteraction()
        {
            Console.WriteLine();
            Console.WriteLine("Finishing the battle, a mirror appears on the ground...");
        }

        public override void PreBattleInteraction()
        {
            Console.WriteLine();
            Console.WriteLine("After returning from Hell our adventures travel to the South West.");
            Console.WriteLine("They encountered a series of tents and hear a booming voice shouting orders.");
            Console.WriteLine("A regiment descends upon them and a they try to fight through it.");
        }
    }
}
