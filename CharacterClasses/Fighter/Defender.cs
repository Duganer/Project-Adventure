using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Abilities;
using System.Collections.Generic;
using System;

namespace ProjectAdventure.CharacterClasses.Fighter
{
    public class Defender : BaseFighter
    {
        public Defender()
        {
            Abilities = new List<Ability>() { new Protect(), new Block2() };
            CharacterType = "Defender";
            CritChance = 1;
            CritDamage = 1;
            DodgeChance = 1;
        }

        public Defender(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new Defender(this);
        }

        public override void IncreaseLevel()
        {
            Level += 1;
            var healthIncrease = random.Next(15, 21);
            Health += healthIncrease;
            MaxHealth += healthIncrease;
            var manaIncrease = random.Next(1, 4);
            Mana += manaIncrease;
            MaxMana += manaIncrease;
            PhysicalAttack += random.Next(1, 3);
            PhysicalDefense += random.Next(4, 7);
            MagicAttack += random.Next(1, 3);
            MagicDefense += random.Next(4, 7);
            Speed += random.Next(1, 3);
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {
                throw new NotImplementedException();
        }
    }
}
