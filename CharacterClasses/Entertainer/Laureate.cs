using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Abilities;
using System.Collections.Generic;
using System;

namespace ProjectAdventure.CharacterClasses.Entertainer
{
    public class Laureate : BaseFighter
    {
        public Laureate()
        {
            Abilities = new List<Ability>() { new Encourage(), new Recite() };
            CharacterType = "Laureate";
            CritChance = 1;
            CritDamage = 1;
            DodgeChance = 1;
        }

        public Laureate(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new Laureate(this);
        }

        public override void IncreaseLevel()
        {
            Level += 1;
            var healthIncrease = random.Next(5, 10);
            Health += healthIncrease;
            MaxHealth += healthIncrease;
            var manaIncrease = random.Next(5, 9);
            Mana += manaIncrease;
            MaxMana += manaIncrease;
            PhysicalAttack += random.Next(2, 4);
            PhysicalDefense += random.Next(2, 4);
            MagicAttack += random.Next(5, 9);
            MagicDefense += random.Next(4, 8);
            Speed += random.Next(2, 4);
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {
            throw new NotImplementedException();
        }
    }
}
