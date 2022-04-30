using ProjectAdventure.CharacterClasses.Common;
using System.Collections.Generic;
using System;
using ProjectAdventure.CharacterClasses.Abilities;

namespace ProjectAdventure.CharacterClasses.Fighter
{
    public class Knight : BaseFighter
    {
        public Knight()
        {
            Abilities = new List<Ability>() { new Block(), new Pierce() };
            CharacterType = "Knight";
            CritChance = 2;
            CritDamage = 2;
            DodgeChance = 1;
        }

        public Knight(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new Knight(this);
        }

        public override void IncreaseLevel()
        {
            Level += 1;
            var healthIncrease = random.Next(11, 17);
            Health += healthIncrease;
            MaxHealth += healthIncrease;
            var manaIncrease = random.Next(1, 4);
            Mana += manaIncrease;
            MaxMana += manaIncrease;
            PhysicalAttack += random.Next(3, 6);
            PhysicalDefense += random.Next(3, 6);
            MagicAttack += random.Next(1, 3);
            MagicDefense += random.Next(1, 3);
            Speed += random.Next(1, 3);
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {
            throw new NotImplementedException();
        }
    }
}
