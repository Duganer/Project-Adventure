using ProjectAdventure.CharacterClasses.Abilities;
using ProjectAdventure.CharacterClasses.Common;
using System.Collections.Generic;

namespace ProjectAdventure.CharacterClasses.Enemies
{
    public class Imp : BaseFighter
    {
        public Imp()
        {
            Level = 1;
            Health = random.Next(40, 50);
            MaxHealth = Health;
            PhysicalAttack = random.Next(4, 10);
            PhysicalDefense = random.Next(8, 15);
            MagicAttack = random.Next(10, 15);
            MagicDefense = random.Next(10, 15);
            Speed = random.Next(15, 20);
            Abilities = new List<Ability>() { new Fire() };
            CharacterType = "Imp";
            Mana = random.Next(20, 31);
            MaxMana = Mana;
            CritChance = 1;
            CritDamage = 1;
            DodgeChance = 3;
        }

        public Imp(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new Imp(this);
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
            PhysicalAttack += random.Next(1, 3);
            PhysicalDefense += random.Next(1, 3);
            MagicAttack += random.Next(2, 5);
            MagicDefense += random.Next(2, 5);
            Speed += random.Next(2, 5);
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {
            throw new System.NotImplementedException();
        }
    }
}
