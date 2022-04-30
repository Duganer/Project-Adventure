using ProjectAdventure.CharacterClasses.Abilities;
using ProjectAdventure.CharacterClasses.Common;
using System.Collections.Generic;

namespace ProjectAdventure.CharacterClasses.Enemies
{
    public class EarthElemental : BaseFighter
    {
        public EarthElemental()
        {
            Level = 10;
            Health = random.Next(500, 600);
            MaxHealth = Health;
            PhysicalAttack = random.Next(25, 35);
            PhysicalDefense = random.Next(50, 60);
            MagicAttack = random.Next(20, 30);
            MagicDefense = random.Next(40, 50);
            Speed = random.Next(10, 15);
            Abilities = new List<Ability>() { new Earthquake() };
            CharacterType = "Elemental";
            Mana = random.Next(60, 80);
            MaxMana = Mana;
            CritChance = 1;
            CritDamage = 1;
            DodgeChance = 1;
        }

        public EarthElemental(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new EarthElemental(this);
        }

        public override void IncreaseLevel()
        {
        }

        public override BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem)
        {
            throw new System.NotImplementedException();
        }
    }
}
