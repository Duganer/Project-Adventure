using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    class Nightfall : Ability
    {
        public Nightfall()
        {
            Name = "Nightfall";
            FlavorText = "Darkness overcomes the enemy and they are hurt in the lack of light.";
            ModifiedStat = StatEnum.MagicAttack;
            Modifier = 12;
            impactedTurns = 0;
            UseOnEnemy = true;
            ManaCost = 5;
        }
    }
}
