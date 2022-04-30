using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Abilities;
using System.Collections.Generic;

namespace ProjectAdventure.CharacterClasses.Mage
{
    public class Paladin : BaseFighter
    {
        public Paladin()
        {
            Abilities = new List<Ability>() { new Cure(), new Smash(), new Holy() };
            CharacterType = "Paladin";
            CritChance = 1;
            CritDamage = 1;
            DodgeChance = 1;
        }

        public Paladin(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new Paladin(this);
        }

        public override void IncreaseLevel()
        {
            Level += 1;
            var healthIncrease = random.Next(10, 17);
            Health += healthIncrease;
            MaxHealth += healthIncrease;
            var manaIncrease = random.Next(2, 7);
            Mana += manaIncrease;
            MaxMana += manaIncrease;
            PhysicalAttack += random.Next(4, 8);
            PhysicalDefense += random.Next(2, 4);
            MagicAttack += random.Next(2, 4);
            MagicDefense += random.Next(4, 8);
            Speed += random.Next(2, 4);
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {
            throw new System.NotImplementedException();
        }
    }
}
