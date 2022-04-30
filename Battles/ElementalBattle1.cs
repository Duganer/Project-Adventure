using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Enemies;
using System;
using System.Collections.Generic;

namespace ProjectAdventure.Battles
{
    public class ElementalBattle1 : Battle
    {
        public ElementalBattle1(List<BaseFighter> units) : base(units)
        {
            Enemies = new List<BaseFighter>();
            Enemies.Add(new EarthElemental() { CharacterName = "Terra" });
            Enemies.Add(new AirElemental() { CharacterName = "Aero" });

            IsFinalBattle = true;
        }

        public override void DetermineNextBattle()
        {
            
        }

        public override void PostBattleInteraction()
        {
            Console.WriteLine();
            Console.WriteLine("After defeating the elementals the citizens all step out of their homes.");
            Console.WriteLine("Despite all of the damage to the city everyone rejoices and a parade is thrown for our heroes.");
            Console.WriteLine("This is the end of their journey for now.");
        }

        public override void PreBattleInteraction()
        {
            Console.WriteLine();
            Console.WriteLine("The final battle is here two large elementals reveal themselves.");
            Console.WriteLine("Everyone but our heros hide who draw their weapond the battle begins.");
        }
    }
}
