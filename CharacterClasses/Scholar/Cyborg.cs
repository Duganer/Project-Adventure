using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Abilities;
using System.Collections.Generic;

namespace ProjectAdventure.CharacterClasses.Scholar
{
    public class Cyborg : BaseFighter
    {
        public Cyborg()
        {
            Abilities = new List<Ability>() { new Laser(), new Charge2() };
            CharacterType = "Cyborg";
            CritChance = 2;
            CritDamage = 2;
            DodgeChance = 1;
        }

        public Cyborg(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new Cyborg(this);
        }

        public override void IncreaseLevel()
        {
            Level += 1;
            var healthIncrease = random.Next(10, 15);
            Health += healthIncrease;
            MaxHealth += healthIncrease;
            var manaIncrease = random.Next(4, 7);
            Mana += manaIncrease;
            MaxMana += manaIncrease;
            PhysicalAttack += random.Next(4, 8);
            PhysicalDefense += random.Next(4, 8);
            MagicAttack += random.Next(3, 6);
            MagicDefense += random.Next(3, 6);
            Speed += random.Next(4, 8);
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {
            throw new System.NotImplementedException();
        }
    }
}
