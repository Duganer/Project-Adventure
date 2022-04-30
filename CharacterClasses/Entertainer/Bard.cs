using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Abilities;
using System.Collections.Generic;
using System;

namespace ProjectAdventure.CharacterClasses.Entertainer
{
    public class Bard : BaseFighter
    {
        public Bard()
        {
            Abilities = new List<Ability>() { new Seduce(), new Melody() };
            CharacterType = "Bard";
            CritChance = 1;
            CritDamage = 1;
            DodgeChance = 2;
            UpgradeItems = new List<UpgradeItemEnum>() { UpgradeItemEnum.Microphone, UpgradeItemEnum.Hat };
        }

        public Bard( BaseFighter fighter ) : base ( fighter ) { }

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
            PhysicalAttack += random.Next(3, 6);
            PhysicalDefense += random.Next(2, 4);
            MagicAttack += random.Next(3, 6);
            MagicDefense += random.Next(2, 4);
            Speed += random.Next(2, 4);
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {
            switch (upgradeItem)
            {
                case UpgradeItemEnum.Hat:
                    {
                        var upgradedUnit = new Performer();
                        upgradedUnit.KeepStatsOnUpgrade(this);
                        return upgradedUnit;
                    }
                case UpgradeItemEnum.Microphone:
                    {
                        var upgradedUnit = new RockStar();
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
