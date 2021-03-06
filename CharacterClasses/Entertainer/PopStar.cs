using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Abilities;
using System.Collections.Generic;

namespace ProjectAdventure.CharacterClasses.Entertainer
{
    public class PopStar : BaseFighter
    {
        public PopStar()
        {
            Abilities = new List<Ability>() { new Lullaby(), new Vocals() };
            CharacterType = "Pop Star";
            CritChance = 1;
            CritDamage = 1;
            DodgeChance = 1;
        }

        public PopStar(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new PopStar(this);
        }

        public override void IncreaseLevel()
        {
            Level += 1;
            var healthIncrease = random.Next(5, 10);
            Health += healthIncrease;
            MaxHealth += healthIncrease;
            var manaIncrease = random.Next(4, 7);
            Mana += manaIncrease;
            MaxMana += manaIncrease;
            PhysicalAttack += random.Next(2, 4);
            PhysicalDefense += random.Next(2, 4);
            MagicAttack += random.Next(4, 8);
            MagicDefense += random.Next(4, 8);
            Speed += random.Next(1, 3);
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {
            throw new System.NotImplementedException();
        }
    }
}
