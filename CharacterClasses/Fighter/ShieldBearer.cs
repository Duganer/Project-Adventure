using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Abilities;
using System.Collections.Generic;
using System;

namespace ProjectAdventure.CharacterClasses.Fighter
{
    public class ShieldBearer : BaseFighter
    {
        public ShieldBearer()
        {
            Abilities = new List<Ability>() { new Block(), new Charge() };
            CharacterType = "Shield Bearer";
            CritChance = 1;
            CritDamage = 1;
            DodgeChance = 1;
        }

        public ShieldBearer(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new ShieldBearer(this);
        }

        public override void IncreaseLevel()
        {
            Level += 1;
            var healthIncrease = random.Next(10, 17);
            Health += healthIncrease;
            MaxHealth += healthIncrease;
            var manaIncrease = random.Next(1, 4);
            Mana += manaIncrease;
            MaxMana += manaIncrease;
            PhysicalAttack += random.Next(1, 4);
            PhysicalDefense += random.Next(3, 6);
            MagicAttack += random.Next(1, 3);
            MagicDefense += random.Next(2, 4);
            Speed += random.Next(1, 3);
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {
            switch (upgradeItem)
            {
                case UpgradeItemEnum.Spear:
                    {
                        var upgradedUnit = new Legion();
                        upgradedUnit.KeepStatsOnUpgrade(this);
                        return upgradedUnit;
                    }
                case UpgradeItemEnum.Helmet:
                    {
                        var upgradedUnit = new Defender();
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
