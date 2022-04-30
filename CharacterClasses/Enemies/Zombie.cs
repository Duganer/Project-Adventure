using ProjectAdventure.CharacterClasses.Abilities;
using ProjectAdventure.CharacterClasses.Common;
using System.Collections.Generic;

namespace ProjectAdventure.CharacterClasses.Enemies
{
    public class Zombie : BaseFighter
    {
        public Zombie()
        {
            Level = 1;
            Health = random.Next(30, 50);
            MaxHealth = Health;
            PhysicalAttack = random.Next(18, 25);
            PhysicalDefense = random.Next(4, 10);
            MagicAttack = random.Next(18, 25);
            MagicDefense = random.Next(4, 10);
            Speed = random.Next(10, 40);
            Abilities = new List<Ability>() { new Slash() };
            CharacterType = "Zombie";
            Mana = random.Next(4, 13);
            MaxMana = Mana;
            CritChance = 3;
            CritDamage = 3;
            DodgeChance = 1;
        }

        public Zombie(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new Zombie(this);
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
            PhysicalDefense += random.Next(1, 3);
            MagicAttack += random.Next(3, 6);
            MagicDefense += random.Next(1, 3);
            Speed += random.Next(1, 8);
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {
            throw new System.NotImplementedException();
        }
    }
}
