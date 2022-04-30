using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Abilities;
using System.Collections.Generic;
using System;

namespace ProjectAdventure.CharacterClasses.Entertainer
{
    public class Shadow : BaseFighter
    {
        public Shadow()
        {
            Abilities = new List<Ability>() { new ShadowAttack(), new Dance() };
            CharacterType = "Shadow";
            CritChance = 2;
            CritDamage = 2;
            DodgeChance = 3;
        }
        public Shadow(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new Shadow(this);
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
            PhysicalAttack += random.Next(6, 10);
            PhysicalDefense += random.Next(3, 6);
            MagicAttack += random.Next(2, 4);
            MagicDefense += random.Next(2, 4);
            Speed += random.Next(5, 8);
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {
            throw new NotImplementedException();
        }
    }
}
