using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    class LightningRush : Ability
    {
        public LightningRush()
        {
            Name = "Lightning Rush";
            FlavorText = "Extra charge a teammate. Increases speed.";
            ModifiedStat = StatEnum.Speed;
            Modifier = 5;
            impactedTurns = 2;
            UseOnEnemy = false;
            ManaCost = 2;
        }
    }
}
