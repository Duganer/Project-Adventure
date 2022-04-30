using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Abilities;
using System.Collections.Generic;
using System;

namespace ProjectAdventure.CharacterClasses.Fighter
{
    public class Monk : BaseFighter
    {
        public Monk()
        {
            Abilities = new List<Ability>() { new SpiritAttack(), new PreciseStrike() };
            CharacterType = "Monk";
            CritChance = 3;
            CritDamage = 3;
            DodgeChance = 3;
        }
        public Monk(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new Monk(this);
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
            PhysicalAttack += random.Next(1, 3);
            PhysicalDefense += random.Next(1, 3);
            MagicAttack += random.Next(3, 6);
            MagicDefense += random.Next(3, 6);
            Speed += random.Next(3, 6);
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {
                throw new NotImplementedException();
        }
    }
}
