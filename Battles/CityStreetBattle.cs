using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Fighter;
using System;
using System.Collections.Generic;

namespace ProjectAdventure.Battles
{
    public class CityStreetBattle : Battle
    {
        public CityStreetBattle(List<BaseFighter> units) : base(units)
        {
            Enemies = new List<BaseFighter>();
            Enemies.Add(new Squire() { CharacterName = "Alexander" });
            Enemies.Add(new Squire() { CharacterName = "Jenna" });
            Enemies.Add(new Squire() { CharacterName = "Ella" });

            IsFinalBattle = false;
        }

        public override void DetermineNextBattle()
        {
            NextBattle = new ForrestBattle(Units);
        }

        public override void PostBattleInteraction()
        {
            Console.WriteLine("Having Defeated the enemies our heroes continue their path along the city streets to the forest to find the evil that has fallen upon the land.");
            foreach(var unit in Units)
            {
                unit.IncreaseLevel();
            }
        }

        public override void PreBattleInteraction()
        {
            Console.WriteLine("Our newly formed party leave the Bar happy and full of drink and food ready to set out on an adventure. After walking the streets for a bit toward the forest a couple of street urchins jump the party and a battle begins.");
        }
    }
}
