using ProjectAdventure.CharacterClasses.Abilities;
using ProjectAdventure.CharacterClasses.Common;
using System.Collections.Generic;

namespace ProjectAdventure.CharacterClasses.Enemies
{
    public class AirElemental : BaseFighter
    {
        public AirElemental()
        {
            Level = 10;
            Health = random.Next(200, 300);
            MaxHealth = Health;
            PhysicalAttack = random.Next(30, 40);
            PhysicalDefense = random.Next(25, 35);
            MagicAttack = random.Next(30, 40);
            MagicDefense = random.Next(25, 35);
            Speed = random.Next(30, 40);
            Abilities = new List<Ability>() { new Hurricane() };
            CharacterType = "Elemental";
            Mana = random.Next(60, 80);
            MaxMana = Mana;
            CritChance = 3;
            CritDamage = 3;
            DodgeChance = 5;
        }

        public AirElemental(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new AirElemental(this);
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
