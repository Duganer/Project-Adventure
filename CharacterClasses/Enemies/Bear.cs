using ProjectAdventure.CharacterClasses.Abilities;
using ProjectAdventure.CharacterClasses.Common;
using System.Collections.Generic;

namespace ProjectAdventure.CharacterClasses.Enemies
{
    public class Bear : BaseFighter
    {
        public Bear()
        {
            Level = 1;
            Health = random.Next(75, 85);
            MaxHealth = Health;
            PhysicalAttack = random.Next(18, 25);
            PhysicalDefense = random.Next(18, 25);
            MagicAttack = random.Next(4, 8);
            MagicDefense = random.Next(4, 8);
            Speed = random.Next(10, 25);
            Abilities = new List<Ability>() { new Slash() };
            CharacterType = "Bear";
            CharacterName = "Winnie";
            Mana = random.Next(4, 13);
            MaxMana = Mana;
            CritChance = 2;
            CritDamage = 2;
            DodgeChance = 1;
        }

        public Bear(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new Bear(this);
        }

        public override void IncreaseLevel()
        {
            Level += 1;
            var healthIncrease = random.Next(5, 10);
            Health += healthIncrease;
            MaxHealth += healthIncrease;
            var manaIncrease = random.Next(1, 4);
            Mana += manaIncrease;
            MaxMana += manaIncrease;
            PhysicalAttack += random.Next(3, 6);
            PhysicalDefense += random.Next(3, 6);
            MagicAttack += random.Next(1, 3);
            MagicDefense += random.Next(1, 3);
            Speed += random.Next(1, 3);
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {
            throw new System.NotImplementedException();
        }
    }
}
