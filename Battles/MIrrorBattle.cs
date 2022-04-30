using ProjectAdventure.CharacterClasses.Common;
using System;
using System.Collections.Generic;

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
            var random = new Random();
            var nextBattleInt = random.Next(1, 5);

            switch(nextBattleInt)
            {
                case 1:
                    {
                        NextBattle = new ReturnToCityBattle1(Units);
                        break;
                    }
                case 2:
                    {
                        NextBattle = new ReturnToCityBattle2(Units);
                        break;
                    }
                case 3:
                    {
                        NextBattle = new ReturnToCityBattle3(Units);
                        break;
                    }
                case 4:
                    {
                        NextBattle = new ReturnToCityBattle4(Units);
                        break;
                    }
                default:
                    {
                        NextBattle = new ReturnToCityBattle1(Units);
                        break;
                    }
            }
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
