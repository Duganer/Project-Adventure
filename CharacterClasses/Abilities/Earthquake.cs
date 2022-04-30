using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    class Earthquake : Ability
    {
        public Earthquake()
        {
            Name = "Earthquake";
            FlavorText = "Everything starts to shake. FInd stable footing.";
            ModifiedStat = StatEnum.PhysicalAttack;
            Modifier = 12;
            impactedTurns = 0;
            UseOnEnemy = true;
            ManaCost = 5;
        }
    }
}
