using ProjectAdventure.CharacterClasses.Abilities;
using ProjectAdventure.CharacterClasses.Common;
using System.Collections.Generic;

namespace ProjectAdventure.CharacterClasses.Enemies
{
    public class Dragon : BaseFighter
    {
        public Dragon()
        {
            Level = 1;
            Health = random.Next(110, 130);
            MaxHealth = Health;
            PhysicalAttack = random.Next(10, 13);
            PhysicalDefense = random.Next(10, 13);
            MagicAttack = random.Next(10, 13);
            MagicDefense = random.Next(10, 13);
            Speed = random.Next(5, 10);
            Abilities = new List<Ability>() { new Fire2() };
            CharacterType = "Dragon";
            Mana = random.Next(12, 21);
            MaxMana = Mana;
            CritChance = 3;
            CritDamage = 3;
            DodgeChance = 2;
        }

        public Dragon(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new Dragon(this);
        }

        public override void IncreaseLevel()
        {
            Level += 1;
            var healthIncrease = random.Next(10, 20);
            Health += healthIncrease;
            MaxHealth += healthIncrease;
            var manaIncrease = random.Next(2, 7);
            Mana += manaIncrease;
            MaxMana += manaIncrease;
            PhysicalAttack += random.Next(2, 5);
            PhysicalDefense += random.Next(2, 5);
            MagicAttack += random.Next(2, 5);
            MagicDefense += random.Next(2, 5);
            Speed += random.Next(1, 3);
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {
            throw new System.NotImplementedException();
        }
    }
}
