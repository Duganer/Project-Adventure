using System;
using System.Collections.Generic;

namespace ProjectAdventure.CharacterClasses.Common
{
    public abstract class BaseFighter
    {
        public BaseFighter()
        { }

        public BaseFighter ( BaseFighter fighter )
        {
            this.CharacterName = fighter.CharacterName;
            this.CharacterType = fighter.CharacterType;
            this.IsUserControlled = false;
            this.Level = fighter.Level;
            this.Health = fighter.Health;
            this.MaxHealth = fighter.MaxHealth;
            this.Mana = fighter.Mana;
            this.MaxMana = fighter.MaxMana;
            this.PhysicalAttack = fighter.PhysicalAttack;
            this.PhysicalDefense = fighter.PhysicalDefense;
            this.MagicAttack = fighter.MagicAttack;
            this.MagicDefense = fighter.MagicDefense;
            this.Speed = fighter.Speed;
            this.CritChance = fighter.CritChance;
            this.CritDamage = fighter.CritDamage;
            this.DodgeChance = fighter.DodgeChance;
            this.Abilities = fighter.Abilities;
        }

        public Random random = new Random();
        public string CharacterName { get; set; }
        public string CharacterType { get; set; }
        public bool IsUserControlled { get; set; }
        public int Level { get; protected set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int Mana { get; set; }
        public int MaxMana { get; set; }
        public int PhysicalAttack { get; set; }
        public int PhysicalDefense { get; set; }
        public int MagicAttack { get; set; }
        public int MagicDefense { get; set; }
        public int Speed { get; set; }
        public int CritChance { get; set; }
        public int CritDamage { get; set; }
        public int DodgeChance { get; set; }
        public int TurnCalculation { get; set; }
        public List<Ability> Abilities { get; set; }
        public abstract void IncreaseLevel();
        public abstract BaseFighter UpgradeClass(UpgradeItemEnum upgradeItem);
        public void KeepStatsOnUpgrade(BaseFighter fighter)
        {
            this.Level = fighter.Level;
            this.Health = fighter.Health;
            this.MaxHealth = fighter.MaxHealth;
            this.Mana = fighter.Mana;
            this.MaxMana = fighter.MaxMana;
            this.PhysicalAttack = fighter.PhysicalAttack;
            this.PhysicalDefense = fighter.PhysicalDefense;
            this.MagicAttack = fighter.MagicAttack;
            this.MagicDefense = fighter.MagicDefense;
            this.Speed = fighter.Speed;
            this.CharacterName = fighter.CharacterName;
            this.IsUserControlled = fighter.IsUserControlled;
        }
        public void ShowStats()
        {
            Console.WriteLine($"Character: {CharacterName}");
            Console.WriteLine($"Class: {CharacterType}");
            Console.WriteLine($"Max Health: {MaxHealth}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Max Mana: {MaxMana}");
            Console.WriteLine($"Mana: {Mana}");
            Console.WriteLine($"Physical Attack: {PhysicalAttack}");
            Console.WriteLine($"Physical Defense: {PhysicalDefense}");
            Console.WriteLine($"MagicAttack: {MagicAttack}");
            Console.WriteLine($"MagicDefense: {MagicDefense}");
            Console.WriteLine($"Speed: {Speed}");
        }

        public List<ModifiedStat> ModifiedStats = new List<ModifiedStat>();

        public List<UpgradeItemEnum> UpgradeItems { get; set; }

        public abstract BaseFighter Clone();
    }
}
