﻿using ProjectAdventure.CharacterClasses.Abilities;
using ProjectAdventure.CharacterClasses.Common;
using System.Collections.Generic;

namespace ProjectAdventure.CharacterClasses.Enemies
{
    public class DarkMage : BaseFighter
    {
        public DarkMage()
        {
            Level = 7;
            Health = random.Next(100, 120);
            MaxHealth = Health;
            PhysicalAttack = random.Next(25, 35);
            PhysicalDefense = random.Next(25, 35);
            MagicAttack = random.Next(40, 50);
            MagicDefense = random.Next(30, 40);
            Speed = random.Next(25, 35);
            Abilities = new List<Ability>() { new Nightfall(), new Fire(), new Wall() };
            CharacterType = "Dark Mage";
            Mana = random.Next(60, 80);
            MaxMana = Mana;
            CritChance = 2;
            CritDamage = 2;
            DodgeChance = 2;
        }

        public DarkMage(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new DarkMage(this);
        }

        public override void IncreaseLevel()
        {
            Level += 1;
            var healthIncrease = random.Next(6, 12);
            Health += healthIncrease;
            MaxHealth += healthIncrease;
            var manaIncrease = random.Next(4, 10);
            Mana += manaIncrease;
            MaxMana += manaIncrease;
            PhysicalAttack += random.Next(1, 3);
            PhysicalDefense += random.Next(1, 3);
            MagicAttack += random.Next(6, 12);
            MagicDefense += random.Next(4, 7);
            Speed += random.Next(2, 4);
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {
            throw new System.NotImplementedException();
        }
    }
}
