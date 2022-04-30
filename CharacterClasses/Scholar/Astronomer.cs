using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Abilities;
using System.Collections.Generic;

namespace ProjectAdventure.CharacterClasses.Scholar
{
    public class Astronomer : BaseFighter
    {
        public Astronomer()
        {
            Abilities = new List<Ability>() { new Meteor(), new SunRay() };
            CharacterType = "Astronomer";
            CritChance = 1;
            CritDamage = 1;
            DodgeChance = 1;
        }

        public Astronomer(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new Astronomer(this);
        }

        public override void IncreaseLevel()
        {
            Level += 1;
            var healthIncrease = random.Next(12, 20);
            Health += healthIncrease;
            MaxHealth += healthIncrease;
            var manaIncrease = random.Next(4, 8);
            Mana += manaIncrease;
            MaxMana += manaIncrease;
            PhysicalAttack += random.Next(2, 4);
            PhysicalDefense += random.Next(2, 4);
            MagicAttack += random.Next(4, 8);
            MagicDefense += random.Next(4, 8);
            Speed += random.Next(2, 4);
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {
            throw new System.NotImplementedException();
        }
    }
}
