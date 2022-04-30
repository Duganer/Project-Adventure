using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    class EnergyBlast : Ability
    {
        public EnergyBlast()
        {
            Name = "Energy Blast";
            FlavorText = "Use a scientific explosion to hit an enemy";
            ModifiedStat = StatEnum.MagicAttack;
            Modifier = 3;
            impactedTurns = 0;
            UseOnEnemy = true;
            ManaCost = 3;
        }
    }
}
