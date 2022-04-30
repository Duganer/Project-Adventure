using ProjectAdventure.CharacterClasses.Common;
using System;
using System.Collections.Generic;
using ProjectAdventure.CharacterClasses.Entertainer;

namespace ProjectAdventure.Battles
{
    class BoxBattle : Battle
    {
        public BoxBattle(List<BaseFighter> units) : base(units)
        {
            Enemies = new List<BaseFighter>();
            Enemies.Add(new Mime() { CharacterName = "Louis" });
            Enemies.Add(new Shadow() { CharacterName = "Erembour" });

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
            Console.WriteLine("Moving to the North East of the continent, Everyone suddenly hits something.");
            Console.WriteLine("They turn left, then right, and finally turn back but they appear to be trapped but can't see what is preventing it.");
            Console.WriteLine("The box around them begins to turn black.");
            Console.WriteLine("Their attackers reveal thesmelf with a large smile.");
        }
    }
}
