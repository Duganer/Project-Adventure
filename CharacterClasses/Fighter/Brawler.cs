using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Abilities;
using System.Collections.Generic;
using System;

namespace ProjectAdventure.CharacterClasses.Fighter
{
    public class Brawler : BaseFighter
    {
        public Brawler()
        {
            Abilities = new List<Ability>() { new Punch(), new Kick() };
            CharacterType = "Brawler";
            CritChance = 3;
            CritDamage = 3;
            DodgeChance = 2;
            UpgradeItems = new List<UpgradeItemEnum>() { UpgradeItemEnum.Sword, UpgradeItemEnum.Staff };
        }

        public Brawler(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new Brawler(this);
        }

        public override void IncreaseLevel()
        {
            Level += 1;
            var healthIncrease = random.Next(9, 15);
            Health += healthIncrease;
            MaxHealth += healthIncrease;
            var manaIncrease = random.Next(1, 4);
            Mana += manaIncrease;
            MaxMana += manaIncrease;
            PhysicalAttack += random.Next(2, 7);
            PhysicalDefense += random.Next(1, 3);
            MagicAttack += random.Next(3, 5);
            MagicDefense += random.Next(2, 4);
            Speed += random.Next(3, 5);
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {
            switch (upgradeItem)
            {
                case UpgradeItemEnum.Sword:
                    {
                        var upgradedUnit = new Ninja();
                        upgradedUnit.KeepStatsOnUpgrade(this);
                        return upgradedUnit;
                    }
                case UpgradeItemEnum.Staff:
                    {
                        var upgradedUnit = new Monk();
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
