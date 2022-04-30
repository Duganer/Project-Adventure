using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Abilities;
using System.Collections.Generic;

namespace ProjectAdventure.CharacterClasses.Scholar
{
    public class TimeTraveller : BaseFighter
    {
        public TimeTraveller()
        {
            Abilities = new List<Ability>() { new WarpSpeed(), new TimeBomb() };
            CharacterType = "Time Traveller";
            CritChance = 1;
            CritDamage = 1;
            DodgeChance = 1;
        }

        public TimeTraveller(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new TimeTraveller(this);
        }

        public override void IncreaseLevel()
        {
            Level += 1;
            var healthIncrease = random.Next(9, 15);
            Health += healthIncrease;
            MaxHealth += healthIncrease;
            var manaIncrease = random.Next(5, 10);
            Mana += manaIncrease;
            MaxMana += manaIncrease;
            PhysicalAttack += random.Next(2, 4);
            PhysicalDefense += random.Next(2, 4);
            MagicAttack += random.Next(2, 4);
            MagicDefense += random.Next(5, 8);
            Speed += random.Next(5, 10);
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {
            throw new System.NotImplementedException();
        }
    }
}
