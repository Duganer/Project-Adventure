using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Abilities;
using System.Collections.Generic;
using System;

namespace ProjectAdventure.CharacterClasses.Entertainer
{
    public class Performer : BaseFighter
    {
        public Performer()
        {
            Abilities = new List<Ability>() { new Inspire(), new Frustrate() };
            CharacterType = "Performer";
            CritChance = 1;
            CritDamage = 1;
            DodgeChance = 1;
        }

        public Performer(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new Performer(this);
        }

        public override void IncreaseLevel()
        {
            Level += 1;
            var healthIncrease = random.Next(5, 10);
            Health += healthIncrease;
            MaxHealth += healthIncrease;
            var manaIncrease = random.Next(5, 8);
            Mana += manaIncrease;
            MaxMana += manaIncrease;
            PhysicalAttack += random.Next(3, 6);
            PhysicalDefense += random.Next(2, 4);
            MagicAttack += random.Next(3, 6);
            MagicDefense += random.Next(4, 8);
            Speed += random.Next(5, 8);
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {
            throw new NotImplementedException();
        }
    }
}
