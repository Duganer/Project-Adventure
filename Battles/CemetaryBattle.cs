using ProjectAdventure.CharacterClasses.Common;
using System;
using System.Collections.Generic;
using ProjectAdventure.CharacterClasses.Enemies;

namespace ProjectAdventure.Battles
{
    class CemetaryBattle : Battle
    {
        public CemetaryBattle(List<BaseFighter> units) : base(units)
        {
            Enemies = new List<BaseFighter>();
            Enemies.Add(new Zombie() { CharacterName = "M" });
            Enemies.Add(new Zombie() { CharacterName = "R" });
            Enemies.Add(new Zombie() { CharacterName = "J" });

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
            Console.WriteLine("With the pirates defeated, everyone travels to the South East.");
            Console.WriteLine("A mist draws over them and it is reveled that the group as found themselves in a cemetary.");
            Console.WriteLine("Three graves have some writing on them and they read M----, R----, and J----.");
            Console.WriteLine($"A hand reaches up from the ground and gets a hold of {Units[0].CharacterName}");
        }
    }
}
