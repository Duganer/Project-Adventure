using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Mage;
using System;
using System.Collections.Generic;

namespace ProjectAdventure.Battles
{
    public class DeepForrestBattle : Battle
    {
        public DeepForrestBattle(List<BaseFighter> units) : base(units)
        {
            Enemies = new List<BaseFighter>();
            Enemies.Add(new Mage() { CharacterName = "Seers" });
            Enemies.Add(new Mage() { CharacterName = "Necromi" });
            Enemies.Add(new Mage() { CharacterName = "Invoques" });

            Enemies[0] = Enemies[0].UpgradeClass(UpgradeItemEnum.BlueStone);
            Enemies[1] = Enemies[1].UpgradeClass(UpgradeItemEnum.YellowStone);
            Enemies[2] = Enemies[2].UpgradeClass(UpgradeItemEnum.RedStone);

            foreach (var enemy in Enemies)
            {
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
            Console.WriteLine("Everyone walks up on a cirlce of sticks, stones, and mud. Everything around them begins to shake and levitate.");
            Console.WriteLine("The sticks catch on fire, an ice storm begins, and strike of lightning flashes across the sky.");
            Console.WriteLine("3 Cackles fill the air as the adventurers prepare for battle.");
        }
    }
}
