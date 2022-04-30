using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    class Cure2 : Ability
    {
        public Cure2()
        {
            Name = "Cure";
            FlavorText = "Restore extra health to a teammate.";
            ModifiedStat = StatEnum.Health;
            Modifier = 30;
            impactedTurns = 0;
            UseOnEnemy = false;
            ManaCost = 7;
        }
    }
}
