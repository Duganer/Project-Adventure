using ProjectAdventure.CharacterClasses.Abilities;
using ProjectAdventure.CharacterClasses.Common;
using System.Collections.Generic;

namespace ProjectAdventure.CharacterClasses.Enemies
{
    public class WaterElemental : BaseFighter
    {
        public WaterElemental()
        {
            Level = 10;
            Health = random.Next(350, 450);
            MaxHealth = Health;
            PhysicalAttack = random.Next(40, 50);
            PhysicalDefense = random.Next(20, 30);
            MagicAttack = random.Next(50, 60);
            MagicDefense = random.Next(20, 30);
            Speed = random.Next(20, 30);
            Abilities = new List<Ability>() { new Tsunami() };
            CharacterType = "Elemental";
            Mana = random.Next(60, 80);
            MaxMana = Mana;
            CritChance = 2;
            CritDamage = 2;
            DodgeChance = 3;
        }

        public WaterElemental(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new WaterElemental(this);
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
