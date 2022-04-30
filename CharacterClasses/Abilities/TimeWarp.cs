using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    class TimeWarp : Ability
    {
        public TimeWarp()
        {
            Name = "Time Warp";
            FlavorText = "Change Time to speed up someone. Increases speed.";
            ModifiedStat = StatEnum.Speed;
            Modifier = 5;
            impactedTurns = 2;
            UseOnEnemy = false;
            ManaCost = 2;
        }
    }
}
