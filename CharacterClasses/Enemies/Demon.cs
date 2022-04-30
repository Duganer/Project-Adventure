using ProjectAdventure.CharacterClasses.Abilities;
using ProjectAdventure.CharacterClasses.Common;
using System.Collections.Generic;

namespace ProjectAdventure.CharacterClasses.Enemies
{
    public class Demon : BaseFighter
    {
        public Demon()
        {
            Level = 1;
            Health = random.Next(80, 100);
            MaxHealth = Health;
            PhysicalAttack = random.Next(4, 8);
            PhysicalDefense = random.Next(4, 8);
            MagicAttack = random.Next(13, 16);
            MagicDefense = random.Next(13, 16);
            Speed = random.Next(5, 10);
            Abilities = new List<Ability>() { new Fire(), new Frustrate() };
            CharacterType = "Demon";
            Mana = random.Next(20, 30);
            MaxMana = Mana;
            CritChance = 2;
            CritDamage = 2;
            DodgeChance = 3;
        }

        public Demon(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new Demon(this);
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
            MagicAttack += random.Next(3, 6);
            MagicDefense += random.Next(3, 6);
            Speed += random.Next(2, 5);
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {
            throw new System.NotImplementedException();
        }
    }
}
