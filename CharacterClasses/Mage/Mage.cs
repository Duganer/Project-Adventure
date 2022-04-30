﻿using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Abilities;
using System;
using System.Collections.Generic;

namespace ProjectAdventure.CharacterClasses.Mage
{
    public class Mage : BaseFighter
    {
        public Mage()
        {
            Level = 1;
            Health = random.Next(45, 52);
            MaxHealth = Health;
            PhysicalAttack = random.Next(10, 17);
            PhysicalDefense = random.Next(10, 15);
            MagicAttack = random.Next(17, 23);
            MagicDefense = random.Next(15, 20);
            Speed = random.Next(13, 17);
            Abilities = new List<Ability>() { new Blast() };
            CharacterType = "Mage";
            UpgradeItems = new List<UpgradeItemEnum>() { UpgradeItemEnum.BlueStone, UpgradeItemEnum.RedStone, UpgradeItemEnum.WhiteStone, UpgradeItemEnum.YellowStone };
            Mana = random.Next(15, 23);
            MaxMana = Mana;
            CritChance = 1;
            CritDamage = 1;
            DodgeChance = 1;
        }

        public Mage(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new Mage(this);
        }

        public override void IncreaseLevel()
        {
            Level += 1;
            var healthIncrease = random.Next(5, 10);
            Health += healthIncrease;
            MaxHealth += healthIncrease;
            var manaIncrease = random.Next(2, 4);
            Mana += manaIncrease;
            MaxMana += manaIncrease;
            PhysicalAttack += random.Next(1, 3);
            PhysicalDefense += random.Next(1, 3);
            MagicAttack += random.Next(1, 3);
            MagicDefense += random.Next(1, 3);
            Speed += random.Next(1, 3);
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {
            switch (upgradeItem)
            {
                case UpgradeItemEnum.BlueStone:
                    {
                        var upgradedUnit = new BlueMage();
                        upgradedUnit.KeepStatsOnUpgrade(this);
                        return upgradedUnit;
                    }
                case UpgradeItemEnum.RedStone:
                    {
                        var upgradedUnit = new RedMage();
                        upgradedUnit.KeepStatsOnUpgrade(this);
                        return upgradedUnit;
                    }
                case UpgradeItemEnum.YellowStone:
                    {
                        var upgradedUnit = new YellowMage();
                        upgradedUnit.KeepStatsOnUpgrade(this);
                        return upgradedUnit;
                    }
                case UpgradeItemEnum.WhiteStone:
                    {
                        var upgradedUnit = new WhiteMage();
                        upgradedUnit.KeepStatsOnUpgrade(this);
                        return upgradedUnit;
                    }
                default:
                    {
                        throw new Exception("How the fuck did you get that upgrade item!");
                    }
            }
        }
    }
}
