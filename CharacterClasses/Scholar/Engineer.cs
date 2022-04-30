using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Abilities;
using System.Collections.Generic;
using System;

namespace ProjectAdventure.CharacterClasses.Scholar
{
    public class Engineer : BaseFighter
    {
        public Engineer()
        {
            Abilities = new List<Ability>() { new Trap(), new SpringLoaded() };
            CharacterType = "Engineer";
            CritChance = 1;
            CritDamage = 1;
            DodgeChance = 1;
            UpgradeItems = new List<UpgradeItemEnum>() { UpgradeItemEnum.Dynamite, UpgradeItemEnum.Brick };
        }

        public Engineer(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new Engineer(this);
        }

        public override void IncreaseLevel()
        {
            Level += 1;
            var healthIncrease = random.Next(9, 15);
            Health += healthIncrease;
            MaxHealth += healthIncrease;
            var manaIncrease = random.Next(2, 5);
            Mana += manaIncrease;
            MaxMana += manaIncrease;
            PhysicalAttack += random.Next(2, 4);
            PhysicalDefense += random.Next(3, 6);
            MagicAttack += random.Next(2, 4);
            MagicDefense += random.Next(2, 4);
            Speed += random.Next(2, 4);
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {

            switch (upgradeItem)
            {
                case UpgradeItemEnum.Brick:
                    {
                        var upgradedUnit = new Builder();
                        upgradedUnit.KeepStatsOnUpgrade(this);
                        return upgradedUnit;
                    }
                case UpgradeItemEnum.Dynamite:
                    {
                        var upgradedUnit = new Demolitionist();
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
