using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    public class PreciseStrike : Ability
    {
        public PreciseStrike()
        {
            Name = "Precise Strike";
            FlavorText = "Find the perfect spot, aim, and hit them right there.";
            ModifiedStat = StatEnum.PhysicalAttack;
            Modifier = 7;
            impactedTurns = 0;
            UseOnEnemy = true;
            ManaCost = 4;
        }
    }
}
