﻿using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Abilities;
using System.Collections.Generic;
using System;

namespace ProjectAdventure.CharacterClasses.Scholar
{
    public class Artificer : BaseFighter
    {
        public Artificer()
        {
            Abilities = new List<Ability>() { new EnergyBlast(), new MagicalTinkering() };
            CharacterType = "Artificer";
            CritChance = 1;
            CritDamage = 1;
            DodgeChance = 1;
            UpgradeItems = new List<UpgradeItemEnum>() { UpgradeItemEnum.Potion, UpgradeItemEnum.Hammer };
        }

        public Artificer(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new Artificer(this);
        }

        public override void IncreaseLevel()
        {
            Level += 1;
            var healthIncrease = random.Next(6, 12);
            Health += healthIncrease;
            MaxHealth += healthIncrease;
            var manaIncrease = random.Next(2, 5);
            Mana += manaIncrease;
            MaxMana += manaIncrease;
            PhysicalAttack += random.Next(3, 6);
            PhysicalDefense += random.Next(2, 4);
            MagicAttack += random.Next(2, 4);
            MagicDefense += random.Next(2, 4);
            Speed += random.Next(1, 3);
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {
            switch (upgradeItem)
            {
                case UpgradeItemEnum.Potion:
                    {
                        var upgradedUnit = new Alchemist();
                        upgradedUnit.KeepStatsOnUpgrade(this);
                        return upgradedUnit;
                    }
                case UpgradeItemEnum.Hammer:
                    {
                        var upgradedUnit = new Armorer();
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
