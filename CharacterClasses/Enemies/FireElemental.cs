using ProjectAdventure.CharacterClasses.Abilities;
using ProjectAdventure.CharacterClasses.Common;
using System.Collections.Generic;

namespace ProjectAdventure.CharacterClasses.Enemies
{
    public class FireElemental : BaseFighter
    {
        public FireElemental()
        {
            Level = 10;
            Health = random.Next(350, 450);
            MaxHealth = Health;
            PhysicalAttack = random.Next(50, 60);
            PhysicalDefense = random.Next(20, 30);
            MagicAttack = random.Next(40, 50);
            MagicDefense = random.Next(20, 30);
            Speed = random.Next(25, 35);
            Abilities = new List<Ability>() { new FireBall() };
            CharacterType = "Elemental";
            Mana = random.Next(60, 80);
            MaxMana = Mana;
            CritChance = 1;
            CritDamage = 1;
            DodgeChance = 1;
        }

        public FireElemental(BaseFighter fighter) : base(fighter) { }

        public override BaseFighter Clone()
        {
            return new FireElemental(this);
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
