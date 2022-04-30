using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Abilities;
using System.Collections.Generic;
using System;

namespace ProjectAdventure.CharacterClasses.Entertainer
{
    public class Dancer : BaseFighter
    {
        public Dancer()
        {
            Abilities = new List<Ability>() { new Seduce(), new Dance() };
            CharacterType = "Dancer";
            CritChance = 2;
            CritDamage = 2;
            DodgeChance = 3;
            UpgradeItems = new List<UpgradeItemEnum>() { UpgradeItemEnum.Light, UpgradeItemEnum.Paint };
        }
        public Dancer(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new Bard(this);
        }

        public override void IncreaseLevel()
        {
            Level += 1;
            var healthIncrease = random.Next(5, 10);
            Health += healthIncrease;
            MaxHealth += healthIncrease;
            var manaIncrease = random.Next(2, 5);
            Mana += manaIncrease;
            MaxMana += manaIncrease;
            PhysicalAttack += random.Next(4, 8);
            PhysicalDefense += random.Next(2, 4);
            MagicAttack += random.Next(2, 4);
            MagicDefense += random.Next(3, 6);
            Speed += random.Next(3, 6);
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {
            switch (upgradeItem)
            {
                case UpgradeItemEnum.Light:
                    {
                        var upgradedUnit = new Shadow();
                        upgradedUnit.KeepStatsOnUpgrade(this);
                        return upgradedUnit;
                    }
                case UpgradeItemEnum.Paint:
                    {
                        var upgradedUnit = new Mime();
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
