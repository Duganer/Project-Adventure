using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    class SpringLoaded : Ability
    {
        public SpringLoaded()
        {
            Name = "Spring Loaded";
            FlavorText = "Launch an enemy violent and wait for their screams to stop when they hit the ground.";
            ModifiedStat = StatEnum.MagicAttack;
            Modifier = 3;
            impactedTurns = 0;
            UseOnEnemy = true;
            ManaCost = 3;
        }
    }
}
