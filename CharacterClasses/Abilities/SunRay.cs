using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    class SunRay : Ability
    {
        public SunRay()
        {
            Name = "Sun Ray";
            FlavorText = "Use the power of the sun to fell an enemy.";
            ModifiedStat = StatEnum.MagicAttack;
            Modifier = 7;
            impactedTurns = 0;
            UseOnEnemy = true;
            ManaCost = 4;
        }
    }
}
