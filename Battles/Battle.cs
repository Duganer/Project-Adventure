using ProjectAdventure.CharacterClasses.Common;
using System;
using System.Linq;
using System.Collections.Generic;

namespace ProjectAdventure.Battles
{
    public abstract class Battle
    {
        public Battle(List<BaseFighter> units)
        {
            Units = units;

            //reset a units health at the beginning of the fight
            foreach (var unit in Units)
            {
                unit.Health = unit.MaxHealth;
                unit.Mana = unit.MaxMana;
            }

            DeadUnits = new List<BaseFighter>();
        }

        public List<BaseFighter> Enemies { get; protected set; }
        public List<BaseFighter> Units { get; protected set; }
        public List<BaseFighter> DeadUnits { get; protected set; }
        public void CheckForDeath()
        {
            var unitsToRemove = new List<int>();
            var enemiesToRemove = new List<int>();

            for (int i = 0; i < Units.Count; i++)
            {
                if (Units[i].Health <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{Units[i].CharacterName} the {Units[i].CharacterType} has been knocked out.");
                    unitsToRemove.Add(i);
                }
            }

            for (int i = 0; i < Enemies.Count; i++)
            {
                if (Enemies[i].Health <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{Enemies[i].CharacterName} the {Enemies[i].CharacterType} has been knocked out.");
                    enemiesToRemove.Add(i);
                }
            }

            for (int i = 0; i < unitsToRemove.Count; i++)
            {
                var unit = unitsToRemove[i] - i;
                DeadUnits.Add(Units[unit]);
                Units.RemoveAt(unit);
            }

            for (int i = 0; i < enemiesToRemove.Count; i++)
            {
                var enemy = enemiesToRemove[i] - i;
                Enemies.RemoveAt(enemy);
            }
        }

        public bool BeginBattle()
        {
            while (Units.Count > 0 && Enemies.Count > 0)
            {
                UpdateTurn();

                if(Units.Any(x => x.TurnCalculation >= 100) || Enemies.Any(y => y.TurnCalculation >= 100))
                {
                    //Most of this will be scrapped if I can get it passed just being text based
                    var actingUnits = Units.Where(x => x.TurnCalculation >= 100).ToList();
                    actingUnits.AddRange(Enemies.Where(x => x.TurnCalculation >= 100));

                    actingUnits.OrderByDescending(x => x.TurnCalculation);
                    foreach (var actingUnit in actingUnits)
                    {
                        //Unit cannot act if they are dead
                        if(actingUnit.Health <= 0)
                        {
                            CheckForDeath();
                            continue;
                        }

                        Console.WriteLine();
                        if (actingUnit.CharacterName.EndsWith('s'))
                        {
                            Console.WriteLine($"It is {actingUnit.CharacterName}' turn.");
                        }
                        else
                        {
                            Console.WriteLine($"It is {actingUnit.CharacterName}'s turn.");
                        }

                        ResetModifiedStat(actingUnit);

                        if (actingUnit.IsUserControlled)
                        {
                            var line = DetermineAction(actingUnit, true);

                            if (line.ToLower() == "attack")
                            {
                                var attackedEnemy = ChooseAffectedUnit(Enemies);
                                PhysicalAttack(actingUnit, attackedEnemy);
                            }
                            else if (line.ToLower() == "ability")
                            {
                                var abilityToUse = DetermineAbility(actingUnit);
                                actingUnit.Mana -= abilityToUse.ManaCost;

                                if (abilityToUse.UseOnEnemy)
                                {
                                    var attackedEnemy = ChooseAffectedUnit(Enemies);
                                    UseAbilityOnEnemy(actingUnit, attackedEnemy, abilityToUse);
                                }
                                else
                                {
                                    var helpedUnit = ChooseAffectedUnit(Units);
                                    UseAbilityOnTeammate(actingUnit, helpedUnit, abilityToUse);
                                }
                            }
                            else if (line.ToLower() == "stats")
                            {
                                foreach (var unit in Units)
                                {
                                    unit.ShowStats();
                                    Console.WriteLine();
                                }

                                foreach (var enemy in Enemies)
                                {
                                    enemy.ShowStats();
                                    Console.WriteLine();
                                }

                                line = DetermineAction(actingUnit, false);

                                if (line.ToLower() == "attack")
                                {
                                    var attackedEnemy = ChooseAffectedUnit(Enemies);
                                    PhysicalAttack(actingUnit, attackedEnemy);
                                }
                                else if (line.ToLower() == "ability")
                                {
                                    var abilityToUse = DetermineAbility(actingUnit);
                                    actingUnit.Mana -= abilityToUse.ManaCost;

                                    if (abilityToUse.UseOnEnemy)
                                    {
                                        var attackedEnemy = ChooseAffectedUnit(Enemies);
                                        UseAbilityOnEnemy(actingUnit, attackedEnemy, abilityToUse);
                                    }
                                    else
                                    {
                                        var helpedUnit = ChooseAffectedUnit(Units);
                                        UseAbilityOnTeammate(actingUnit, helpedUnit, abilityToUse);
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (actingUnit.Abilities.Count > 0 && actingUnit.Abilities.Any(x => x.ManaCost <= actingUnit.Mana))
                            {
                                var possibleAbilities = actingUnit.Abilities.Where(x => x.ManaCost <= actingUnit.Mana).ToList();
                                var abilityToUse = possibleAbilities[actingUnit.random.Next(0, possibleAbilities.Count)];
                                actingUnit.Mana -= abilityToUse.ManaCost;

                                if (abilityToUse.UseOnEnemy)
                                {
                                    var attackedUnit = Units[actingUnit.random.Next(0, Units.Count)];
                                    UseAbilityOnEnemy(actingUnit, attackedUnit, abilityToUse);
                                }
                                else
                                {
                                    var helpedUnit = Enemies.OrderByDescending(x => x.Health).First();
                                    UseAbilityOnTeammate(actingUnit, helpedUnit, abilityToUse);
                                }
                            }
                            else
                            {
                                var attackedUnit = Units[actingUnit.random.Next(0, Units.Count)];
                                PhysicalAttack(actingUnit, attackedUnit);
                            }
                        }

                        CheckForDeath();

                        if(Units.Count == 0 || Enemies.Count == 0)
                        {
                            break;
                        }
                    }

                    ResetTurns();
                }
            }

            if(Enemies.Count > 0)
            {
                return true;
            }
            else
            {
                //add dead units back to the party
                Units.AddRange(DeadUnits);
                return false;
            }
        }

        public void UpdateTurn()
        {
            foreach (var unit in Units)
            {
                unit.TurnCalculation += unit.Speed;
            }

            foreach (var enemy in Enemies)
            {
                enemy.TurnCalculation += enemy.Speed;
            }
        }

        public void UseAbilityOnTeammate(BaseFighter actingUnit, BaseFighter helpedUnit, Ability abilityToUse)
        {
            if (abilityToUse.impactedTurns == 0)
            {
                var healthRegen = abilityToUse.Modifier + actingUnit.MagicAttack;

                helpedUnit.Health += healthRegen;
                if (helpedUnit.Health > helpedUnit.MaxHealth)
                {
                    helpedUnit.Health = helpedUnit.MaxHealth;
                }

                Console.WriteLine();
                Console.WriteLine(abilityToUse.FlavorText);
                Console.WriteLine($"{helpedUnit.CharacterName} healed {healthRegen} points of damage.");
            }
            else
            {
                helpedUnit.ModifiedStats.Add(new ModifiedStat()
                {
                    Modifier = abilityToUse.Modifier,
                    Stat = abilityToUse.ModifiedStat,
                    Turns = abilityToUse.impactedTurns,
                    IsNegative = false
                });

                ModifyStats(helpedUnit, abilityToUse.ModifiedStat, abilityToUse.Modifier, false);

                Console.WriteLine();
                Console.WriteLine(abilityToUse.FlavorText);
                Console.WriteLine($"{helpedUnit.CharacterName} was impacted by the ability.");
            }
        }

        public void UseAbilityOnEnemy(BaseFighter actingUnit, BaseFighter attackedEnemy, Ability abilityToUse)
        {
            if (abilityToUse.impactedTurns == 0)
            {
                var damage = 0;

                if (abilityToUse.ModifiedStat == StatEnum.MagicAttack)
                {
                    damage = abilityToUse.Modifier + actingUnit.MagicAttack - attackedEnemy.MagicDefense;
                }
                else if (abilityToUse.ModifiedStat == StatEnum.PhysicalAttack)
                {
                    damage = abilityToUse.Modifier + actingUnit.PhysicalAttack - attackedEnemy.PhysicalDefense;
                }

                if (damage < 0)
                {
                    damage = 0;
                }

                if (CheckForCritical(actingUnit))
                {
                    damage += actingUnit.CritDamage;
                }

                attackedEnemy.Health -= damage;
                Console.WriteLine();
                Console.WriteLine(abilityToUse.FlavorText);
                Console.WriteLine($"{actingUnit.CharacterName} did {damage} points of damage to {attackedEnemy.CharacterName}.");
            }
            else
            {
                attackedEnemy.ModifiedStats.Add(new ModifiedStat()
                {
                    Modifier = abilityToUse.Modifier,
                    Stat = abilityToUse.ModifiedStat,
                    Turns = abilityToUse.impactedTurns,
                    IsNegative = true
                });

                ModifyStats(attackedEnemy, abilityToUse.ModifiedStat, abilityToUse.Modifier, true);

                Console.WriteLine();
                Console.WriteLine(abilityToUse.FlavorText);
                Console.WriteLine($"{attackedEnemy.CharacterName} was hit with this ability.");
            }
        }

        public void PhysicalAttack(BaseFighter actingUnit, BaseFighter attackedEnemy)
        {
            var damage = actingUnit.PhysicalAttack - attackedEnemy.PhysicalDefense;
            if (damage < 0)
            {
                damage = 0;
            }

            if (CheckForCritical(actingUnit))
            {
                damage += actingUnit.CritDamage;
            }

            if(CheckForDodge(attackedEnemy))
            {
                Console.WriteLine();
                Console.WriteLine($"The attack from {actingUnit.CharacterName} missed");
            }
            else
            {
                attackedEnemy.Health -= damage;

                Console.WriteLine();
                Console.WriteLine($"{actingUnit.CharacterName} did {damage} points of damage to {attackedEnemy.CharacterName}.");
            }
        }

        public string DetermineAction(BaseFighter actingUnit, bool isFirstCheck)
        {
            var line = string.Empty;

            if (isFirstCheck)
            {
                Console.WriteLine();
                if (actingUnit.Abilities.Any(x => x.ManaCost <= actingUnit.Mana))
                {
                    Console.WriteLine("Would you like to 'Attack', use an 'Ability', or show 'Stats'? Press Enter when ready.");
                }
                else
                {
                    Console.WriteLine("Would you like to 'Attack' or show 'Stats'? Press Enter when ready.");
                }

                line = Console.ReadLine();
                if (line.ToLower() != "attack" && line.ToLower() != "ability" && line.ToLower() != "stats")
                {
                    line = "attack";
                }
            }
            else
            {
                Console.WriteLine();
                if (actingUnit.Abilities.Any(x => x.ManaCost <= actingUnit.Mana))
                {
                    Console.WriteLine("Would you like to 'Attack' or use an 'Ability'? Press Enter when ready.");
                    line = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You don't have enough mana and must attack.");
                    line = "attack";
                }

                if (line.ToLower() != "attack" && line.ToLower() != "ability")
                {
                    line = "attack";
                }
            }

            return line;
        }

        public Ability DetermineAbility(BaseFighter actingUnit)
        {
            Console.WriteLine();
            Console.WriteLine($"Which ability do you want to use? Type number and press enter.");
            var i = 1;

            foreach (var ability in actingUnit.Abilities)
            {
                if (ability.ManaCost <= actingUnit.Mana)
                {
                    Console.WriteLine($"{i}. {ability.Name}");
                }
            }
            var abilityNumber = Console.ReadLine();

            int.TryParse(abilityNumber, out int abilityToUseNumber);

            if (abilityToUseNumber <= 0 || abilityToUseNumber > actingUnit.Abilities.Count)
            {
                abilityToUseNumber = 1;
            }

            var abilityToUse = actingUnit.Abilities[abilityToUseNumber - 1];

            return abilityToUse;
        }
        
        public BaseFighter ChooseAffectedUnit(List<BaseFighter> fighters)
        {
            Console.WriteLine();
            Console.WriteLine("Enter the number of the character you would like to affect and press enter.");

            int i = 1;
            foreach (var unit in fighters)
            {
                Console.WriteLine($"{i}. {unit.CharacterName} the {unit.CharacterType}");
                i++;
            }

            var unitNumber = Console.ReadLine();
            int.TryParse(unitNumber, out int affectedUnitNumber);

            if(affectedUnitNumber <= 0 || affectedUnitNumber > fighters.Count)
            {
                affectedUnitNumber = 1;
            }

            var affectedUnit = fighters[affectedUnitNumber - 1];

            return affectedUnit;
        }

        public void ResetTurns()
        {
            foreach (var unit in Units)
            {
                if(unit.TurnCalculation >= 100)
                {
                    unit.TurnCalculation -= 100;
                }
            }

            foreach (var enemy in Enemies)
            {
                if (enemy.TurnCalculation >= 100)
                {
                    enemy.TurnCalculation -= 100;
                }
            }
        }

        public void ModifyStats(BaseFighter fighter, StatEnum modifiedStat, int modifier, bool negativeImpact)
        {
            switch (modifiedStat)
            {
                case StatEnum.Attack:
                    {
                        if(negativeImpact)
                        {
                            fighter.PhysicalAttack -= modifier;
                            fighter.MagicAttack -= modifier;
                        }
                        else
                        {
                            fighter.PhysicalAttack += modifier;
                            fighter.MagicAttack += modifier;
                        }
                        break;
                    }
                case StatEnum.Defense:
                    {
                        if (negativeImpact)
                        {
                            fighter.PhysicalDefense -= modifier;
                            fighter.MagicDefense -= modifier;
                        }
                        else
                        {
                            fighter.PhysicalDefense += modifier;
                            fighter.MagicDefense += modifier;
                        }
                        break;
                    }
                case StatEnum.PhysicalAttack:
                    {
                        if (negativeImpact)
                        {
                            fighter.PhysicalAttack -= modifier;
                        }
                        else
                        {
                            fighter.PhysicalAttack += modifier;
                        }
                        break;
                    }
                case StatEnum.MagicAttack:
                    {
                        if (negativeImpact)
                        {
                            fighter.MagicAttack -= modifier;
                        }
                        else
                        {
                            fighter.MagicAttack += modifier;
                        }
                        break;
                    }
                case StatEnum.PhysicalDefense:
                    {
                        if (negativeImpact)
                        {
                            fighter.PhysicalDefense -= modifier;
                        }
                        else
                        {
                            fighter.PhysicalDefense += modifier;
                        }
                        break;
                    }
                case StatEnum.MagicDefense:
                    {
                        if (negativeImpact)
                        {
                            fighter.MagicDefense -= modifier;
                        }
                        else
                        {
                            fighter.MagicDefense += modifier;
                        }
                        break;
                    }
                case StatEnum.Speed:
                    {
                        if (negativeImpact)
                        {
                            fighter.Speed -= modifier;
                        }
                        else
                        {
                            fighter.Speed += modifier;
                        }
                        break;
                    }
            }
        }

        public void ResetModifiedStat(BaseFighter fighter)
        {
            var statsToRemove = new List<int>();

            for (int i = 0; i < fighter.ModifiedStats.Count; i++)
            {
                var modifiedStat = fighter.ModifiedStats[i];
                if (modifiedStat.Turns == 0)
                {
                    ModifyStats(fighter, modifiedStat.Stat, modifiedStat.Modifier, !modifiedStat.IsNegative);
                    statsToRemove.Add(i);
                }
                else
                {
                    modifiedStat.Turns -= 1;
                }
            }

            for (int i = 0; i < statsToRemove.Count; i++)
            {
                var stat = statsToRemove[i] - i;
                fighter.ModifiedStats.RemoveAt(stat);
            }
        }

        private bool CheckForCritical(BaseFighter fighter)
        {
            var critRoll = fighter.random.Next(1, 11);
            return critRoll > 10 - fighter.CritChance;
        }

        private bool CheckForDodge(BaseFighter fighter)
        {
            var dodgeRoll = fighter.random.Next(1, 11);
            return dodgeRoll <= fighter.DodgeChance;
        }

        public abstract void DetermineNextBattle();

        public bool IsFinalBattle { get; set; }

        public Battle NextBattle { get; set; }

        public abstract void PreBattleInteraction();
        public abstract void PostBattleInteraction();
    }
}
