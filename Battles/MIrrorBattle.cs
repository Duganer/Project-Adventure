using ProjectAdventure.CharacterClasses.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectAdventure.Battles
{
    class MirrorBattle : Battle
    {
        public MirrorBattle(List<BaseFighter> units) : base(units)
        {
            Enemies = new List<BaseFighter>();

            foreach (var unit in Units)
            {
                var enemy = unit.Clone();
                Enemies.Add(enemy);
            }

            IsFinalBattle = false;
        }

        public override void DetermineNextBattle()
        {
            NextBattle = new ReturnToCityBattle(Units);
        }

        public override void PostBattleInteraction()
        {
            Console.WriteLine();
            Console.WriteLine("After defeating the shadow clones, the mirror now has writing on it.");
            Console.WriteLine("In cloud letters is written 'Return to the city'");
            foreach (var unit in Units)
            {
                unit.IncreaseLevel();
            }
        }

        public override void PreBattleInteraction()
        {
            Console.WriteLine();
            Console.WriteLine("Picking up the mirror everyone looks into it.");
            Console.WriteLine($"{Units[1].CharacterName} notices dark clouds forming behind them.");
            Console.WriteLine("The clouds look to be taking the shape of the team.");
        }
    }
}
