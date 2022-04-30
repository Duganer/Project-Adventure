using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Abilities;
using System.Collections.Generic;

namespace ProjectAdventure.CharacterClasses.Mage
{
    public class Priest : BaseFighter
    {
        public Priest()
        {
            Abilities = new List<Ability>() { new Cure2(), new Protect(), new Holy() };
            CharacterType = "Priest";
            CritChance = 1;
            CritDamage = 1;
            DodgeChance = 1;
        }

        public Priest(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new Priest(this);
        }

        public override void IncreaseLevel()
        {
            Level += 1;
            var healthIncrease = random.Next(6, 14);
            Health += healthIncrease;
            MaxHealth += healthIncrease;
            var manaIncrease = random.Next(4, 9);
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
