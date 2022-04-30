using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Abilities;
using System.Collections.Generic;
using System;

namespace ProjectAdventure.CharacterClasses.Fighter
{
    public class Hunter : BaseFighter
    {
        public Hunter()
        {
            Abilities = new List<Ability>() { new TripleArrow(), new SpringLoaded() };
            CharacterType = "Hunter";
            CritChance = 3;
            CritDamage = 3;
            DodgeChance = 4;
        }

        public Hunter(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new Hunter(this);
        }

        public override void IncreaseLevel()
        {
            Level += 1;
            var healthIncrease = random.Next(9, 15);
            Health += healthIncrease;
            MaxHealth += healthIncrease;
            var manaIncrease = random.Next(3, 8);
            Mana += manaIncrease;
            MaxMana += manaIncrease;
            PhysicalAttack += random.Next(1, 3);
            PhysicalDefense += random.Next(1, 3);
            MagicAttack += random.Next(4, 7);
            MagicDefense += random.Next(2, 4);
            Speed += random.Next(3, 6);
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {
                throw new NotImplementedException();
        }
    }
}
