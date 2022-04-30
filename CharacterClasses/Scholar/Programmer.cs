using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Abilities;
using System.Collections.Generic;

namespace ProjectAdventure.CharacterClasses.Scholar
{
    public class Programmer : BaseFighter
    {
        public Programmer()
        {
            Abilities = new List<Ability>() { new Random(), new ProgramDefense(), new ProgramDefense() };
            CharacterType = "Programmer";
            CritChance = 1;
            CritDamage = 1;
            DodgeChance = 1;
        }

        public Programmer(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new Programmer(this);
        }

        public override void IncreaseLevel()
        {
            Level += 1;
            var healthIncrease = random.Next(10, 20);
            Health += healthIncrease;
            MaxHealth += healthIncrease;
            var manaIncrease = random.Next(10, 20);
            Mana += manaIncrease;
            MaxMana += manaIncrease;
            PhysicalAttack += random.Next(2, 4);
            PhysicalDefense += random.Next(2, 4);
            MagicAttack += random.Next(3, 6);
            MagicDefense += random.Next(2, 4);
            Speed += random.Next(2, 4);
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {
            throw new System.NotImplementedException();
        }
    }
}
