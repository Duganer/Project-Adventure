﻿using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Abilities;
using System.Collections.Generic;
using System;

namespace ProjectAdventure.CharacterClasses.Fighter
{
    public class Ranger : BaseFighter
    {
        public Ranger()
        {
            Abilities = new List<Ability>() { new Pierce(), new DoubleArrow() };
            CharacterType = "Ranger";
            CritChance = 3;
            CritDamage = 3;
            DodgeChance = 1;
        }

        public Ranger(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new Ranger(this);
        }

        public override void IncreaseLevel()
        {
            Level += 1;
            var healthIncrease = random.Next(6, 12);
            Health += healthIncrease;
            MaxHealth += healthIncrease;
            var manaIncrease = random.Next(1, 4);
            Mana += manaIncrease;
            MaxMana += manaIncrease;
            PhysicalAttack += random.Next(2, 5);
            PhysicalDefense += random.Next(1, 3);
            MagicAttack += random.Next(3, 5);
            MagicDefense += random.Next(1, 3);
            Speed += random.Next(2, 5);
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {
            switch (upgradeItem)
            {
                case UpgradeItemEnum.Gun:
                    {
                        var upgradedUnit = new Mercenary();
                        upgradedUnit.KeepStatsOnUpgrade(this);
                        return upgradedUnit;
                    }
                case UpgradeItemEnum.Trap:
                    {
                        var upgradedUnit = new Hunter();
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
