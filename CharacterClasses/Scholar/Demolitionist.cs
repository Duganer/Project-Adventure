using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Abilities;
using System.Collections.Generic;

namespace ProjectAdventure.CharacterClasses.Scholar
{
    public class Demolitionist : BaseFighter
    {
        public Demolitionist()
        {
            Abilities = new List<Ability>() { new Explosion(), new Fire() };
            CharacterType = "Demolitionist";
            CritChance = 1;
            CritDamage = 1;
            DodgeChance = 1;
        }

        public Demolitionist(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new Demolitionist(this);
        }

        public override void IncreaseLevel()
        {
            Level += 1;
            var healthIncrease = random.Next(9, 15);
            Health += healthIncrease;
            MaxHealth += healthIncrease;
            var manaIncrease = random.Next(2, 5);
            Mana += manaIncrease;
            MaxMana += manaIncrease;
            PhysicalAttack += random.Next(2, 4);
            PhysicalDefense += random.Next(2, 4);
            MagicAttack += random.Next(4, 7);
            MagicDefense += random.Next(4, 7);
            Speed += random.Next(2, 4);
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {
            throw new System.NotImplementedException();
        }
    }
}
