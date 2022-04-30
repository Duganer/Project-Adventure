using ProjectAdventure.CharacterClasses.Abilities;
using ProjectAdventure.CharacterClasses.Common;
using System.Collections.Generic;

namespace ProjectAdventure.CharacterClasses.Enemies
{
    public class Captain : BaseFighter
    {
        public Captain()
        {
            Level = 1;
            Health = random.Next(60, 80);
            MaxHealth = Health;
            PhysicalAttack = random.Next(13, 16);
            PhysicalDefense = random.Next(13, 16);
            MagicAttack = random.Next(4, 8);
            MagicDefense = random.Next(4, 8);
            Speed = random.Next(5, 10);
            Abilities = new List<Ability>() { new Explosion() };
            CharacterType = "Captain";
            Mana = random.Next(15, 25);
            MaxMana = Mana;
            CritChance = 3;
            CritDamage = 5;
            DodgeChance = 1;
        }

        public Captain(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new Captain(this);
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
            PhysicalAttack += random.Next(3, 6);
            PhysicalDefense += random.Next(3, 6);
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
