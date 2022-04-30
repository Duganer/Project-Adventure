using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Abilities;
using System.Collections.Generic;
using System;

namespace ProjectAdventure.CharacterClasses.Fighter
{
    public class Cavalry : BaseFighter
    {
        public Cavalry()
        {
            Abilities = new List<Ability>() { new Slash(), new Charge2() };
            CharacterType = "Cavalry";
            CritChance = 2;
            CritDamage = 2;
            DodgeChance = 2;
        }

        public Cavalry(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new Cavalry(this);
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
            MagicAttack += random.Next(1, 3);
            MagicDefense += random.Next(1, 3);
            Speed += random.Next(3, 6);
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {
            throw new NotImplementedException();
        }
    }
}
