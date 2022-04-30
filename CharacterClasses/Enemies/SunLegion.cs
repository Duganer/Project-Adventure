using ProjectAdventure.CharacterClasses.Abilities;
using ProjectAdventure.CharacterClasses.Common;
using System.Collections.Generic;

namespace ProjectAdventure.CharacterClasses.Enemies
{
    public class SunLegion : BaseFighter
    {
        public SunLegion()
        {
            Level = 7;
            Health = random.Next(140, 160);
            MaxHealth = Health;
            PhysicalAttack = random.Next(35, 40);
            PhysicalDefense = random.Next(35, 40);
            MagicAttack = random.Next(25, 35);
            MagicDefense = random.Next(30, 40);
            Speed = random.Next(25, 35);
            Abilities = new List<Ability>() { new Launch(), new Lunge(), new LightSpear() };
            CharacterType = "Light Legion";
            Mana = random.Next(30, 40);
            MaxMana = Mana;
            CritChance = 2;
            CritDamage = 2;
            DodgeChance = 2;
        }

        public SunLegion(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new SunLegion(this);
        }

        public override void IncreaseLevel()
        {
            Level += 1;
            var healthIncrease = random.Next(9, 15);
            Health += healthIncrease;
            MaxHealth += healthIncrease;
            var manaIncrease = random.Next(1, 4);
            Mana += manaIncrease;
            MaxMana += manaIncrease;
            PhysicalAttack += random.Next(4, 7);
            MagicDefense += random.Next(3, 5);
            MagicAttack += random.Next(6, 9);
            MagicDefense += random.Next(3, 5);
            Speed += random.Next(2, 4);
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {
            throw new System.NotImplementedException();
        }
    }
}
