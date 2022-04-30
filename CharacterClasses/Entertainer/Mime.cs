using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Abilities;
using System.Collections.Generic;
using System;

namespace ProjectAdventure.CharacterClasses.Entertainer
{
    public class Mime : BaseFighter
    {
        public Mime()
        {
            Abilities = new List<Ability>() { new Wall(), new Anvil() };
            CharacterType = "Mime";
            CritChance = 2;
            CritDamage = 2;
            DodgeChance = 3;
        }

        public Mime(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new Mime(this);
        }

        public override void IncreaseLevel()
        {
            Level += 1;
            var healthIncrease = random.Next(8, 13);
            Health += healthIncrease;
            MaxHealth += healthIncrease;
            var manaIncrease = random.Next(5, 8);
            Mana += manaIncrease;
            MaxMana += manaIncrease;
            PhysicalAttack += random.Next(2, 4);
            PhysicalDefense += random.Next(2, 4);
            MagicAttack += random.Next(4, 8);
            MagicDefense += random.Next(4, 8);
            Speed += random.Next(2, 5);
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {
            throw new NotImplementedException();
        }
    }
}
