using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Abilities;
using System;
using System.Collections.Generic;

namespace ProjectAdventure.CharacterClasses.Entertainer
{
    public class Entertainer : BaseFighter
    {
        public Entertainer()
        {
            Level = 1;
            Health = random.Next(45, 52);
            MaxHealth = Health;
            PhysicalAttack = random.Next(10, 17);
            PhysicalDefense = random.Next(10, 15);
            MagicAttack = random.Next(12, 20);
            MagicDefense = random.Next(15, 20);
            Speed = random.Next(15, 20);
            Abilities = new List<Ability>() { new Sing() };
            CharacterType = "Entertainer";
            UpgradeItems = new List<UpgradeItemEnum>() { UpgradeItemEnum.Guitar, UpgradeItemEnum.Slippers, UpgradeItemEnum.Microphone, UpgradeItemEnum.Chapbook };
            Mana = random.Next(10, 17);
            MaxMana = Mana;
            CritChance = 1;
            CritDamage = 1;
            DodgeChance = 1;
        }

        public Entertainer(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new Entertainer(this);
        }
        public override void IncreaseLevel()
        {
            Level += 1;
            var healthIncrease = random.Next(5, 10);
            Health += healthIncrease;
            MaxHealth += healthIncrease;
            var manaIncrease = random.Next(1, 3);
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
                case UpgradeItemEnum.Guitar:
                    {
                        var upgradedUnit = new Bard();
                        upgradedUnit.KeepStatsOnUpgrade(this);
                        return upgradedUnit;
                    }
                case UpgradeItemEnum.Slippers:
                    {
                        var upgradedUnit = new Dancer();
                        upgradedUnit.KeepStatsOnUpgrade(this);
                        return upgradedUnit;
                    }
                case UpgradeItemEnum.Chapbook:
                    {
                        var upgradedUnit = new Poet();
                        upgradedUnit.KeepStatsOnUpgrade(this);
                        return upgradedUnit;
                    }
                case UpgradeItemEnum.Microphone:
                    {
                        var upgradedUnit = new Singer();
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
