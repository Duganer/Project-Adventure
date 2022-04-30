using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Abilities;
using System.Collections.Generic;
using System;

namespace ProjectAdventure.CharacterClasses.Entertainer
{
    public class Scribe : BaseFighter
    {
        public Scribe()
        {
            Abilities = new List<Ability>() { new Frustrate(), new Inspire() };
            CharacterType = "Scribe";
            CritChance = 1;
            CritDamage = 1;
            DodgeChance = 1;
        }
        public Scribe(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new Scribe(this);
        }

        public override void IncreaseLevel()
        {
            Level += 1;
            var healthIncrease = random.Next(8, 13);
            Health += healthIncrease;
            MaxHealth += healthIncrease;
            var manaIncrease = random.Next(2, 5);
            Mana += manaIncrease;
            MaxMana += manaIncrease;
            PhysicalAttack += random.Next(2, 4);
            PhysicalDefense += random.Next(2, 4);
            MagicAttack += random.Next(2, 4);
            MagicDefense += random.Next(6, 10);
            Speed += random.Next(6, 9);
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {
            throw new NotImplementedException();
        }
    }
}
