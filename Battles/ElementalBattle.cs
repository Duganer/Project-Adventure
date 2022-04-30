using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Enemies;
using System;
using System.Collections.Generic;

namespace ProjectAdventure.Battles
{
    public class ElementalBattle : Battle
    {
        public ElementalBattle(List<BaseFighter> units) : base(units)
        {
            Enemies = new List<BaseFighter>();

            var random = new Random().Next(0,3);

            switch(random)
            {
                case 0:
                    {
                        Enemies.Add(new EarthElemental() { CharacterName = "Terra" });
                        break;
                    }
                case 1:
                    {
                        Enemies.Add(new AirElemental() { CharacterName = "Aero" });
                        break;
                    }
                case 2:
                    {
                        Enemies.Add(new WaterElemental() { CharacterName = "Ariel" });
                        break;
                    }
                case 3:
                    {
                        Enemies.Add(new FireElemental() { CharacterName = "Ember" });
                        break;
                    }
            }

            IsFinalBattle = true;
        }

        public override void DetermineNextBattle()
        {
            
        }

        public override void PostBattleInteraction()
        {
            Console.WriteLine();
            Console.WriteLine("After defeating the elemental the citizens all step out of their homes.");
            Console.WriteLine("Despite all of the damage to the city everyone rejoices and a parade is thrown for our heroes.");
            Console.WriteLine("This is the end of their journey for now.");
        }

        public override void PreBattleInteraction()
        {
            Console.WriteLine();
            Console.WriteLine("The final battle is here a large elemental reveals itself.");
            Console.WriteLine("Everyone but our heros hide who draw their weapond the battle begins.");
        }
    }
}
