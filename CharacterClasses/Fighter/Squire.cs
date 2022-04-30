using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Abilities;
using System;
using System.Collections.Generic;

namespace ProjectAdventure.CharacterClasses.Fighter
{
    public class Squire : BaseFighter
    {
        public Squire()
        {
            Level = 1;
            Health = random.Next(50, 60);
            MaxHealth = Health;
            PhysicalAttack = random.Next(15, 20);
            PhysicalDefense = random.Next(13, 17);
            MagicAttack = random.Next(7, 10);
            MagicDefense = random.Next(10, 15);
            Speed = random.Next(10, 15);
            Abilities = new List<Ability>() { new Slash() };
            CharacterType = "Squire";
            UpgradeItems = new List<UpgradeItemEnum>() { UpgradeItemEnum.Sword, UpgradeItemEnum.Bow, UpgradeItemEnum.Shield, UpgradeItemEnum.Headband };
            Mana = random.Next(4, 13);
            MaxMana = Mana;
            CritChance = 2;
            CritDamage = 2;
            DodgeChance = 1;
        }

        public Squire(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new Squire(this);
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
                case UpgradeItemEnum.Sword:
                    {
                        var upgradedUnit = new SwordFighter();
                        upgradedUnit.KeepStatsOnUpgrade(this);
                        return upgradedUnit;
                    }
                case UpgradeItemEnum.Shield:
                    {
                        var upgradedUnit = new ShieldBearer();
                        upgradedUnit.KeepStatsOnUpgrade(this);
                        return upgradedUnit;
                    }
                case UpgradeItemEnum.Bow:
                    {
                        var upgradedUnit = new Ranger();
                        upgradedUnit.KeepStatsOnUpgrade(this);
                        return upgradedUnit;
                    }
                case UpgradeItemEnum.Headband:
                    {
                        var upgradedUnit = new Brawler();
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
