using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Abilities;
using System.Collections.Generic;

namespace ProjectAdventure.CharacterClasses.Scholar
{
    public class Armorer : BaseFighter
    {
        public Armorer()
        {
            Abilities = new List<Ability>() { new Block2(), new Smash() };
            CharacterType = "Armorer";
            CritChance = 1;
            CritDamage = 1;
            DodgeChance = 1;
        }

        public Armorer(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new Armorer(this);
        }

        public override void IncreaseLevel()
        {
            Level += 1;
            var healthIncrease = random.Next(8, 15);
            Health += healthIncrease;
            MaxHealth += healthIncrease;
            var manaIncrease = random.Next(2, 5);
            Mana += manaIncrease;
            MaxMana += manaIncrease;
            PhysicalAttack += random.Next(3, 6);
            PhysicalDefense += random.Next(5, 10);
            MagicAttack += random.Next(2, 4);
            MagicDefense += random.Next(5, 10);
            Speed += random.Next(1, 3);
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {
            throw new System.NotImplementedException();
        }
    }
}
