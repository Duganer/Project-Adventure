using ProjectAdventure.CharacterClasses.Common;
using ProjectAdventure.CharacterClasses.Abilities;
using System.Collections.Generic;

namespace ProjectAdventure.CharacterClasses.Mage
{
    public class MagmaMage : BaseFighter
    {
        public MagmaMage()
        {
            Abilities = new List<Ability>() { new Fire(), new Lava(), new Wall() };
            CharacterType = "Magma Mage";
            CritChance = 2;
            CritDamage = 2;
            DodgeChance = 1;
        }

        public MagmaMage(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new MagmaMage(this);
        }

        public override void IncreaseLevel()
        {
            Level += 1;
            var healthIncrease = random.Next(6, 12);
            Health += healthIncrease;
            MaxHealth += healthIncrease;
            var manaIncrease = random.Next(4, 10);
            Mana += manaIncrease;
            MaxMana += manaIncrease;
            PhysicalAttack += random.Next(1, 3);
            PhysicalDefense += random.Next(1, 3);
            MagicAttack += random.Next(6, 12);
            MagicDefense += random.Next(4, 7);
            Speed += random.Next(2, 4);
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {
            throw new System.NotImplementedException();
        }
    }
}
