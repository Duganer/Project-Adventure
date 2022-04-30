using ProjectAdventure.CharacterClasses.Abilities;
using ProjectAdventure.CharacterClasses.Common;
using System.Collections.Generic;

namespace ProjectAdventure.CharacterClasses.Enemies
{
    public class Pirate : BaseFighter
    {
        public Pirate()
        {
            Level = 1;
            Health = random.Next(60, 80);
            MaxHealth = Health;
            PhysicalAttack = random.Next(10, 13);
            PhysicalDefense = random.Next(10, 13);
            MagicAttack = random.Next(5, 10);
            MagicDefense = random.Next(5, 10);
            Speed = random.Next(5, 10);
            Abilities = new List<Ability>() { new GunShot() };
            CharacterType = "Pirate";
            Mana = random.Next(10, 20);
            MaxMana = Mana;
            CritChance = 2;
            CritDamage = 4;
            DodgeChance = 2;
        }

        public Pirate(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new Pirate(this);
        }

        public override void IncreaseLevel()
        {
            Level += 1;
            var healthIncrease = random.Next(5, 10);
            Health += healthIncrease;
            MaxHealth += healthIncrease;
            var manaIncrease = random.Next(2, 7);
            Mana += manaIncrease;
            MaxMana += manaIncrease;
            PhysicalAttack += random.Next(2, 5);
            PhysicalDefense += random.Next(2, 5);
            MagicAttack += random.Next(1, 3);
            MagicDefense += random.Next(1, 3);
            Speed += random.Next(2, 5);
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {
            throw new System.NotImplementedException();
        }
    }
}
