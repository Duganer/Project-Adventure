using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    public class Dance : Ability
    {
        public Dance()
        {
            Name = "Dance";
            FlavorText = "Tap all over your enemies faces.";
            ModifiedStat = StatEnum.PhysicalAttack;
            Modifier = 3;
            impactedTurns = 0;
            UseOnEnemy = true;
            ManaCost = 3;
        }
    }
}
