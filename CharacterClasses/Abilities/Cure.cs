using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    class Cure : Ability
    {
        public Cure()
        {
            Name = "Cure";
            FlavorText = "Restore health to a teammate.";
            ModifiedStat = StatEnum.Health;
            Modifier = 20;
            impactedTurns = 0;
            UseOnEnemy = false;
            ManaCost = 5;
        }
    }
}
