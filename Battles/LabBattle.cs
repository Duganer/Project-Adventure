using ProjectAdventure.CharacterClasses.Common;
using System;
using System.Collections.Generic;
using ProjectAdventure.CharacterClasses.Scholar;

namespace ProjectAdventure.Battles
{
    class LabBattle : Battle
    {
        public LabBattle(List<BaseFighter> units) : base(units)
        {
            Enemies = new List<BaseFighter>();
            Enemies.Add(new Cyborg() { CharacterName = "Deus" });
            Enemies.Add(new Builder() { CharacterName = "Ananiah" });
            Enemies.Add(new Armorer() { CharacterName = "Acrid" });

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
            Console.WriteLine("Travelling to the North West, everyone begins to notice static in the air.");
            Console.WriteLine("A large building looms in the distance and the group enters it trying to figure out the cause.");
            Console.WriteLine("Outlined under a cloth a human shape lies on a table.");
            Console.WriteLine("The cloth drops to the ground and a laser blasts past the party.");
        }
    }
}
