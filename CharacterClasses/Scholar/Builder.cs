using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Abilities;
using System.Collections.Generic;

namespace ProjectAdventure.CharacterClasses.Scholar
{
    public class Builder : BaseFighter
    {
        public Builder()
        {
            Abilities = new List<Ability>() { new Smash(), new Wall() };
            CharacterType = "Builder";
            CritChance = 1;
            CritDamage = 1;
            DodgeChance = 1;
        }

        public Builder(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new Builder(this);
        }

        public override void IncreaseLevel()
        {
            Level += 1;
            var healthIncrease = random.Next(11, 17);
            Health += healthIncrease;
            MaxHealth += healthIncrease;
            var manaIncrease = random.Next(2, 5);
            Mana += manaIncrease;
            MaxMana += manaIncrease;
            PhysicalAttack += random.Next(4, 7);
            PhysicalDefense += random.Next(4, 8);
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
