using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    class TripleArrow : Ability
    {
        public TripleArrow()
        {
            Name = "Triple Arrow";
            FlavorText = "Shoot an Enemy with 3 arrows at once.";
            ModifiedStat = StatEnum.PhysicalAttack;
            Modifier = 9;
            impactedTurns = 0;
            UseOnEnemy = true;
            ManaCost = 5;
        }
    }
}
