using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Abilities;
using System.Collections.Generic;

namespace ProjectAdventure.CharacterClasses.Entertainer
{
    public class RockStar : BaseFighter
    {
        public RockStar()
        {
            Abilities = new List<Ability>() { new Solo(), new Smash() };
            CharacterType = "Rock Star";
            CritChance = 1;
            CritDamage = 1;
            DodgeChance = 1;
        }
        public RockStar(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new RockStar(this);
        }

        public override void IncreaseLevel()
        {
            Level += 1;
            var healthIncrease = random.Next(5, 10);
            Health += healthIncrease;
            MaxHealth += healthIncrease;
            var manaIncrease = random.Next(2, 5);
            Mana += manaIncrease;
            MaxMana += manaIncrease;
            PhysicalAttack += random.Next(5, 8);
            PhysicalDefense += random.Next(4, 7);
            MagicAttack += random.Next(2, 4);
            MagicDefense += random.Next(2, 4);
            Speed += random.Next(2, 4);
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {
            throw new System.NotImplementedException();
        }
    }
}
