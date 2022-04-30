using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Abilities;
using System.Collections.Generic;
using System;

namespace ProjectAdventure.CharacterClasses.Fighter
{
    public class Mercenary : BaseFighter
    {
        public Mercenary()
        {
            Abilities = new List<Ability>() { new GunShot(), new Pierce() };
            CharacterType = "Monk";
            CritChance = 3;
            CritDamage = 5;
            DodgeChance = 1;
        }
        public Mercenary(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new Mercenary(this);
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
            PhysicalDefense += random.Next(2, 4);
            MagicAttack += random.Next(1, 3);
            MagicDefense += random.Next(1, 3);
            Speed += random.Next(2, 5);
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {
                throw new NotImplementedException();
        }
    }
}
