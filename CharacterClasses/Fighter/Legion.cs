using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Abilities;
using System.Collections.Generic;
using System;

namespace ProjectAdventure.CharacterClasses.Fighter
{
    public class Legion : BaseFighter
    {
        public Legion()
        {
            Abilities = new List<Ability>() { new Lunge(), new Launch() };
            CharacterType = "Legion";
            CritChance = 2;
            CritDamage = 2;
            DodgeChance = 2;
        }
        public Legion(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new Legion(this);
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
            PhysicalAttack += random.Next(3, 6);
            PhysicalDefense += random.Next(1, 3);
            MagicAttack += random.Next(4, 7);
            MagicDefense += random.Next(1, 3);
            Speed += random.Next(2, 4);
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {
                throw new NotImplementedException();
        }
    }
}
