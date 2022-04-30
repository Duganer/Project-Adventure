using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    class WarpSpeed : Ability
    {
        public WarpSpeed()
        {
            Name = "Warp Speed";
            FlavorText = "Accelerate a teammate beyond their limits. Increases speed.";
            ModifiedStat = StatEnum.Speed;
            Modifier = 10;
            impactedTurns = 2;
            UseOnEnemy = false;
            ManaCost = 4;
        }
    }
}
