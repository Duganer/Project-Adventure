using ProjectAdventure.CharacterClasses.Abilities;
using ProjectAdventure.CharacterClasses.Common;
using System.Collections.Generic;

namespace ProjectAdventure.CharacterClasses.Enemies
{
    public class SuperStar1 : BaseFighter
    {
        public SuperStar1()
        {
            Level = 7;
            Health = random.Next(100, 120);
            MaxHealth = Health;
            PhysicalAttack = random.Next(25, 35);
            PhysicalDefense = random.Next(25, 35);
            MagicAttack = random.Next(40, 50);
            MagicDefense = random.Next(30, 40);
            Speed = random.Next(25, 35);
            Abilities = new List<Ability>() { new Lullaby(), new Vocals(), new VocalSolo() };
            CharacterType = "Super Star";
            Mana = random.Next(30, 40);
            MaxMana = Mana;
            CritChance = 1;
            CritDamage = 1;
            DodgeChance = 1;
        }

        public SuperStar1(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new SuperStar1(this);
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
            PhysicalAttack += random.Next(3, 5);
            MagicDefense += random.Next(3, 5);
            MagicAttack += random.Next(6, 9);
            MagicDefense += random.Next(6, 9);
            Speed += random.Next(1, 3);
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {
            throw new System.NotImplementedException();
        }
    }
}
