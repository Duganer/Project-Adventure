using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Abilities;
using System.Collections.Generic;
using System;

namespace ProjectAdventure.CharacterClasses.Mage
{
    public class YellowMage : BaseFighter
    {
        public YellowMage()
        {
            Abilities = new List<Ability>() { new Lightning(), new Wind() };
            CharacterType = "Yellow Mage";
            CritChance = 2;
            CritDamage = 2;
            DodgeChance = 1;
            UpgradeItems = new List<UpgradeItemEnum>() { UpgradeItemEnum.LightningStone, UpgradeItemEnum.AirStone };
        }

        public YellowMage(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new YellowMage(this);
        }

        public override void IncreaseLevel()
        {
            Level += 1;
            var healthIncrease = random.Next(6, 12);
            Health += healthIncrease;
            MaxHealth += healthIncrease;
            var manaIncrease = random.Next(2, 7);
            Mana += manaIncrease;
            MaxMana += manaIncrease;
            PhysicalAttack += random.Next(1, 3);
            PhysicalDefense += random.Next(1, 3);
            MagicAttack += random.Next(4, 8);
            MagicDefense += random.Next(3, 6);
            Speed += random.Next(2, 4);
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {

            switch (upgradeItem)
            {
                case UpgradeItemEnum.LightningStone:
                    {
                        var upgradedUnit = new LightningMage();
                        upgradedUnit.KeepStatsOnUpgrade(this);
                        return upgradedUnit;
                    }
                case UpgradeItemEnum.AirStone:
                    {
                        var upgradedUnit = new AirMage();
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
