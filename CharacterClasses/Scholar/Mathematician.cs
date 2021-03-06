using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Abilities;
using System.Collections.Generic;
using System;

namespace ProjectAdventure.CharacterClasses.Scholar
{
    public class Mathematician : BaseFighter
    {
        public Mathematician()
        {
            Abilities = new List<Ability>() { new Proof(), new BlackHole() };
            CharacterType = "Mathematician";
            CritChance = 1;
            CritDamage = 1;
            DodgeChance = 1;
            UpgradeItems = new List<UpgradeItemEnum>() { UpgradeItemEnum.CyberneticImplant, UpgradeItemEnum.Computer };
        }

        public Mathematician(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new Mathematician(this);
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
            PhysicalAttack += random.Next(2, 4);
            PhysicalDefense += random.Next(2, 4);
            MagicAttack += random.Next(3, 6);
            MagicDefense += random.Next(2, 4);
            Speed += random.Next(2, 4);
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {

            switch (upgradeItem)
            {
                case UpgradeItemEnum.CyberneticImplant:
                    {
                        var upgradedUnit = new Cyborg();
                        upgradedUnit.KeepStatsOnUpgrade(this);
                        return upgradedUnit;
                    }
                case UpgradeItemEnum.Computer:
                    {
                        var upgradedUnit = new Programmer();
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
