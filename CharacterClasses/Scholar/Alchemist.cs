using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Abilities;
using System.Collections.Generic;

namespace ProjectAdventure.CharacterClasses.Scholar
{
    public class Alchemist : BaseFighter
    {
        public Alchemist()
        {
            Abilities = new List<Ability>() { new Blight(), new MagicalTinkering() };
            CharacterType = "Alchemist";
            CritChance = 1;
            CritDamage = 1;
            DodgeChance = 1;
        }

        public Alchemist(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new Alchemist(this);
        }

        public override void IncreaseLevel()
        {
            Level += 1;
            var healthIncrease = random.Next(6, 12);
            Health += healthIncrease;
            MaxHealth += healthIncrease;
            var manaIncrease = random.Next(5, 10);
            Mana += manaIncrease;
            MaxMana += manaIncrease;
            PhysicalAttack += random.Next(5, 8);
            PhysicalDefense += random.Next(2, 4);
            MagicAttack += random.Next(5, 8);
            MagicDefense += random.Next(2, 4);
            Speed += random.Next(1, 3);
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {
            throw new System.NotImplementedException();
        }
    }
}
